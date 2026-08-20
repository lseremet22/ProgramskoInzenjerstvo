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
            VehicleRepository vehicleRepo = new VehicleRepository();
            vehicleRepo.editVehicleDetails(new Vehicle(modelBox.Text, makerBox.Text, registrationDateBox.Text,
                int.Parse(kilometersBox.Text), int.Parse(manufacturingYearBox.Text),
                v.getRegistrationNumber(), (fuelComboBox.SelectedItem).ToString(), 
                float.Parse(consumptionBox.Text), (groupComboBox.SelectedItem).ToString()), fuelComboBox.SelectedIndex + 1,
                groupComboBox.SelectedIndex + 1);

            //povratak na detalje o vozilima s promjenama
            Vehicle vehicle = new Vehicle(modelBox.Text, makerBox.Text, registrationDateBox.Text, int.Parse(kilometersBox.Text), int.Parse(manufacturingYearBox.Text),
               v.getRegistrationNumber(),(fuelComboBox.SelectedItem).ToString(), float.Parse(consumptionBox.Text), (groupComboBox.SelectedItem).ToString());
            VehicleDetails vehicleDetails = new VehicleDetails(employee, this.ClientSize.Width, this.ClientSize.Height, vehicle);
            this.Hide();
            vehicleDetails.Show();
        }
    }
}
