using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    public class ServiceRepository
    {
        private readonly string connectionString =
            "Server=31.147.206.65;" +
            "Database=PI2526_lseremet22_DB;" +
            "User Id=PI2526_lseremet22;" +
            "Password=7*sW1R}.&7K)B-.);";

        //metoda upisuje u bazu podataka da je vozilo servisirano
        public  void sendToService(Vehicle vehicle)
        {
            string query =
                "insert into servisi values(SYSDATETIME(), DATEADD(DAY, 1, SYSDATETIME()),@registracija,@brojkilometara);" +
                "\n" +
                "update vozila set datumregistracije = DATEADD(DAY, 1, SYSDATETIME()) where registracija = @registracija;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@registracija", vehicle.getRegistrationNumber().ToString());
                    command.Parameters.AddWithValue("@brojkilometara", vehicle.getNumberOfKilometers());
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
