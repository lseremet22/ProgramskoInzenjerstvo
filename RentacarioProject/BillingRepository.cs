using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Net;
using System.Net.Mail;

namespace RentacarioProject
{
    public class BillingRepository
    {
        private readonly string connectionString =
            "Server=31.147.206.65;" +
            "Database=PI2526_lseremet22_DB;" +
            "User Id=PI2526_lseremet22;" +
            "Password=7*sW1R}.&7K)B-.);";

        public BillingRepository()
        {
        }

        public List<UnpaidBillingDataObject> getUnpaidBillingData()
        {
            List<UnpaidBillingDataObject> list = new List<UnpaidBillingDataObject>();

            //query koji dohvaca rezervacije koje jos nisu placene
            String query =
                "SELECT kupci.ime, " +
                "kupci.prezime, " +
                "kupci.oib, " +
                "rezervacije.kraj, " +
                "vozila.marka, " +
                "vozila.naziv, " +
                "vozila.registracija, " +
                "rezervacije.brojkilometara, " +
                "vrstegoriva.nazivgoriva AS gorivo " +
                "FROM rezervacije " +
                "JOIN vozila ON vozila.registracija = rezervacije.registracija " +
                "JOIN kupci ON kupci.oib = rezervacije.oib " +
                "JOIN vrstegoriva ON vrstegoriva.IDgoriva = vozila.vrstagoriva " +
                "WHERE NOT EXISTS (" +
                 "SELECT 1 FROM naplate " +
                 "WHERE naplate.registracija = rezervacije.registracija " +
                 "AND naplate.brojkilometarastari = rezervacije.brojkilometara" +
                  ");";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        UnpaidBillingDataObject transferObject = new UnpaidBillingDataObject(
                            reader["ime"].ToString(),
                            reader["prezime"].ToString(),
                            reader["oib"].ToString(),
                            Convert.ToDateTime(reader["kraj"]),
                            reader["marka"].ToString(),
                            reader["naziv"].ToString(),
                            reader["registracija"].ToString(),
                            int.Parse(reader["brojkilometara"].ToString()),
                            reader["gorivo"].ToString()
                         );

                        list.Add(transferObject);
                    }
                }
            }

            return list;
        }


        //spremi informacije o naplati u bazu podataka
        public void saveBillingData(Billing bill)
        {
            string query ="INSERT INTO naplate (steta, brojkilometarastari, iznos,zaposlenik,registracija,brojkilometaranovi)" +
                " VALUES (@steta, @brojkilometarastari, @iznos,@zaposlenik,@registracija,@brojkilometaranovi)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@steta", bill.getDamage());
                    command.Parameters.AddWithValue("@brojkilometarastari", bill.getOldKilometers());
                    command.Parameters.AddWithValue("@iznos", bill.getAMmount());
                    command.Parameters.AddWithValue("@zaposlenik", bill.getEmployee().getUsername());
                    command.Parameters.AddWithValue("@registracija", bill.getRegistration());
                    command.Parameters.AddWithValue("@brojkilometaranovi", bill.getNewKilometers());
                    command.ExecuteNonQuery();
                }
            }
        }

        //metoda koja salje mail kupcu sa informacijama o naplati
        public void sendEmail(String email, Billing bill)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("lukaseremet1@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Informacije o placanju";

            mail.Body =
                "Poštovani,\n\n" +
                "naplata za najam vozila je uspješno evidentirana.\n\n" +
                "Registracija vozila: " + bill.getRegistration() + "\n" +
                "Stari broj kilometara: " + bill.getOldKilometers() + "\n" +
                "Novi broj kilometara: " + bill.getNewKilometers() + "\n" +
                "Iznos: " + bill.getAMmount() + " €\n\n" +
                "Srddačan pozdrav,\n" +
                "Rentacario";

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(
                    "lukaseremet1@gmail.com",
                    "vprb dayr wllo cukv"
                );

                smtp.Send(mail);
            }
        }
    }
}
