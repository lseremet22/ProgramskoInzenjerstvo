using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RentacarioProject
{
    public class FuelPriceRepository
    {
        private readonly string connectionString =
        "Server=31.147.206.65;" +
        "Database=PI2526_lseremet22_DB;" +
        "User Id=PI2526_lseremet22;" +
        "Password=7*sW1R}.&7K)B-.);";

        //cita fuelorices iz baze
        public FuelPrice getFuelPrices()
        {
            FuelPrice fuelPrice = null;
            string query = "SELECT * FROM cijenegoriva";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                            fuelPrice = new FuelPrice(
                            float.Parse(reader["dizel"].ToString()),
                            float.Parse(reader["benzin"].ToString()),
                            Convert.ToDateTime(reader["uneseno"])
                        );
                }
            }
            return fuelPrice;
        }


    //unosi fuelprices u bazu
    public void setFuelPrices(float dieselPrice, float gasPrice)
        {
            string query = "DELETE * FROM cijenegoriva;\n"+
                "INSERT INTO cijenegoriva (dizel, benzin, uneseno) VALUES (@dieselPrice, @gasPrice, SYSDATETIME())";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dieselPrice", dieselPrice);
                    command.Parameters.AddWithValue("@gasPrice", gasPrice);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
