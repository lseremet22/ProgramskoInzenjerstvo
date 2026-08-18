using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
public class ActiveReservationsRepository
    {
        private readonly string connectionString =
            "Server=31.147.206.65;" +
            "Database=PI2526_lseremet22_DB;" +
            "User Id=PI2526_lseremet22;" +
            "Password=7*sW1R}.&7K)B-.);";

        public List<Reservation> getActiveReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            string query =
                "SELECT rezervacije.OIB, vrsterezervacija.naziv, " +
                "rezervacije.registracija, rezervacije.brojkilometara, " +
                "rezervacije.pocetak, rezervacije.kraj, " +
                "kupci.ime, kupci.prezime " +
                "FROM rezervacije " +
                "JOIN kupci ON rezervacije.OIB = kupci.OIB " +
                "JOIN vrsterezervacija " +
                "ON rezervacije.vrstarezervacije = vrsterezervacija.IDrezervacije " +
                "WHERE SYSDATETIME() <= kraj " +
                "AND SYSDATETIME() >= pocetak;";

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reservation reservation = new Reservation(
                            reader["OIB"].ToString(),
                            reader["naziv"].ToString(),
                            reader["registracija"].ToString(),
                            int.Parse(reader["brojkilometara"].ToString()),
                            Convert.ToDateTime(reader["pocetak"]),
                            Convert.ToDateTime(reader["kraj"]),
                            reader["ime"].ToString(),
                            reader["prezime"].ToString()
                        );

                        reservations.Add(reservation);
                    }
                }
            }

            return reservations;
        }
    }
}