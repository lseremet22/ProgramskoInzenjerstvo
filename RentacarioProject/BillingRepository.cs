using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace RentacarioProject
{
    public class BillingRepository
    {
        private readonly string connectionString =
            "Server=31.147.206.65;" +
            "Database=PI2526_lseremet22_DB;" +
            "User Id=PI2526_lseremet22;" +
            "Password=7*sW1R}.&7K)B-.);";

        public List<UnpaidBillingDataObject> getUnpaidBillingData()
        {
            List<UnpaidBillingDataObject> list = new List<UnpaidBillingDataObject>();

            //query koji dohvaca rezervacije koje jos nisu placene
            String query = "select kupci.ime,\r\nkupci.prezime," +
                "\r\nkupci.oib,\r\nrezervacije.kraj,\r\nvozila.marka," +
                "\r\nvozila.naziv,\r\nvozila.registracija,\r\nrezervacije.brojkilometara" +
                "\r\nfrom rezervacije" +
                "\r\njoin vozila ON vozila.registracija=rezervacije.registracija" +
                "\r\njoin kupci on kupci.oib=rezervacije.oib" +
                " WHERE NOT EXISTS(SELECT 1 FROM naplate WHERE " +
                "naplate.registracija = rezervacije.registracija AND " +
                "naplate.brojkilometarastari = rezervacije.brojkilometara);";

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
                            int.Parse(reader["brojkilometara"].ToString())
                         );

                        list.Add(transferObject);
                    }
                }
            }

            return list;
        }

    }
}
