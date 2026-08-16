using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentacarioProject
{
    public partial class EditVehicle : Form
    {
        private String connectionString =
        "Server=31.147.206.65;" +
        "Database=PI2526_lseremet22_DB;" +
        "User Id=PI2526_lseremet22;" +
        "Password=7*sW1R}.&7K)B-.);";

        private Employee employee;
        private int width;
        private int height;
        private Vehicle v;
        public EditVehicle(Employee employee, int width, int height, Vehicle v)
        {
            InitializeComponent();
            this.employee = employee;
            this.width = width;
            this.height = height;
            this.v = v;
        }

        private void EditVehicle_Load(object sender, EventArgs e)
        {
            registrationLabel.Text = v.getRegistrationNumber();
            modelBox.Text = v.getModel();
            makerBox.Text = v.getBrand();
            registrationDateBox.Text = v.getRegistrationDate();
            kilometersBox.Text = v.getNumberOfKilometers().ToString();
            manufacturingYearBox.Text = v.getYearOfProduction().ToString();
            consumptionBox.Text = v.getFuelConsumption().ToString();
            fuelComboBox.Items.AddRange(new string[] { "benzin", "dizel"});
            fuelComboBox.SelectedItem = v.getTypeOfFuel();
            groupComboBox.Items.AddRange(new string[] { "osobno vozilo", "putnicki kombi", "terertno vozilo", "limuzina"});
            groupComboBox.SelectedItem = v.getGroup();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        { 
            this.Hide();
            VehicleDetails vehicleDetails = new VehicleDetails(employee, this.ClientSize.Width, this.ClientSize.Height, v);
            vehicleDetails.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
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
                    command.Parameters.AddWithValue("@model", modelBox.Text);
                    command.Parameters.AddWithValue("@brand", makerBox.Text);
                    command.Parameters.AddWithValue("@registrationDate", DateTime.Parse(registrationDateBox.Text));
                    command.Parameters.AddWithValue("@numberOfKilometers", int.Parse(kilometersBox.Text));
                    command.Parameters.AddWithValue("@yearOfProduction", int.Parse(manufacturingYearBox.Text));
                    command.Parameters.AddWithValue("@typeOfFuel", fuelComboBox.SelectedIndex+1);
                    command.Parameters.AddWithValue("@fuelConsumption", float.Parse(consumptionBox.Text));
                    command.Parameters.AddWithValue("@vehicleGroup", groupComboBox.SelectedIndex+1);
                    command.Parameters.AddWithValue("@registrationNumber", v.getRegistrationNumber());

                    command.ExecuteNonQuery();
                }
            }

            //povratak na detalje o vozilima s promjenama

            Vehicle vehicle = new Vehicle(modelBox.Text, makerBox.Text, registrationDateBox.Text, int.Parse(kilometersBox.Text), int.Parse(manufacturingYearBox.Text),
               v.getRegistrationNumber(),(fuelComboBox.SelectedIndex + 1).ToString(), float.Parse(consumptionBox.Text), (groupComboBox.SelectedIndex + 1).ToString());
            VehicleDetails vehicleDetails = new VehicleDetails(employee, this.ClientSize.Width, this.ClientSize.Height, vehicle);
            this.Hide();
            vehicleDetails.Show();
        }
    }
}
