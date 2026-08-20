using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    public class VehicleRepository
    {
        private String connectionString =
            "Server=31.147.206.65;" +
            "Database=PI2526_lseremet22_DB;" +
            "User Id=PI2526_lseremet22;" +
            "Password=7*sW1R}.&7K)B-.);";

        public void deleteVehicle(Vehicle v)
        {
            //spajanje na bazu i brisanje vozila
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String query = "DELETE FROM vozila WHERE registracija = @registrationNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@registrationNumber", v.getRegistrationNumber());
                    command.ExecuteNonQuery();
                }
            }
        }

        public void editVehicleDetails(Vehicle v, int fuelIndex, int groupIndex)
        {
            //spajanje na bazu i pohrana promjena
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE vozila SET naziv=@model, marka=@brand, datumregistracije=@registrationDate, brojkilometara=@numberOfKilometers," +
                    " godiste=@yearOfProduction, vrstagoriva=@typeOfFuel, potrosnja=@fuelConsumption, skupina=@vehicleGroup " +
                    "WHERE registracija=@registrationNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@model", v.getModel());
                    command.Parameters.AddWithValue("@brand", v.getBrand());
                    command.Parameters.AddWithValue("@registrationDate", DateTime.Parse(v.getRegistrationDate()));
                    command.Parameters.AddWithValue("@numberOfKilometers", int.Parse(v.getNumberOfKilometers().ToString()));
                    command.Parameters.AddWithValue("@yearOfProduction", int.Parse(v.getYearOfProduction().ToString()));
                    command.Parameters.AddWithValue("@typeOfFuel", fuelIndex);
                    command.Parameters.AddWithValue("@fuelConsumption", float.Parse(v.getFuelConsumption().ToString()));
                    command.Parameters.AddWithValue("@vehicleGroup", groupIndex);
                    command.Parameters.AddWithValue("@registrationNumber", v.getRegistrationNumber());

                    command.ExecuteNonQuery();
                }
            }
        }

        public void editVehicleKilometers(String registration, int numberOfKilometers)
        {
            //spajanje na bazu i pohrana promjena
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE vozila SET brojkilometara=@numberOfKilometers WHERE registracija=@registrationNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numberOfKilometers", numberOfKilometers);
                    command.Parameters.AddWithValue("@registrationNumber", registration);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
