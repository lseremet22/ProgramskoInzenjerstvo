using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentacarioProject
{
    public partial class AllCars : Form
    {
        private String connectionString = 
        "Server=31.147.206.65;" +
        "Database=PI2526_lseremet22_DB;" +
        "User Id=PI2526_lseremet22;" +
        "Password=7*sW1R}.&7K)B-.);";

        private Employee employee;
        private Vehicle vehicle;
        private List<Vehicle> listOfVehicles = new List<Vehicle>();


        // metoda koja prikazuje sve automobile iz liste u panelima
        private void displayVehicles(List<Vehicle> listOfVehicles)
        {
            flowLayoutPanelVehicles.Controls.Clear();

            foreach (Vehicle v in listOfVehicles) {
                Panel panel = new Panel();
                panel.Size = new Size(400, 180);
                panel.BorderStyle = BorderStyle.Fixed3D;

                //dodavanje podataka
                Label label = new Label();
                label.Text = "Marka: "+v.getBrand() + "\nModel: " + v.getModel()
                    + "\nDatum registracije: " + v.getRegistrationDate() + "\nBroj kilometara: " + v.getNumberOfKilometers()
                    + "\nGodiste: " + v.getYearOfProduction()+ "\nRegistracija: " + v.getRegistrationNumber()
                    + "\nVrsta goriva: " + v.getTypeOfFuel()+ "\nPotrošnja: " + v.getFuelConsumption()+ "\nVrsta vozila: " + v.getGroup();
                label.Location = new Point(10, 10);
                label.AutoSize = true;
                panel.Controls.Add(label);

                //dodavanje slike
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile("C:\\Users\\lukas\\source\\repos\\lseremet22\\ProgramskoInzenjerstvo\\RentacarioProject\\Images\\ibizaEdited.png");
                pictureBox.Location = new Point(label.Width + 15, 15);
                pictureBox.Size = new Size(200, 120);
                panel.Controls.Add(pictureBox);

                //dodavanje buttona
                Button button = new Button();
                button.Text = "Detalji";
                button.Name = "button"+v.getRegistrationNumber();
                button.Location = new Point((panel.Width-button.Width)/2, label.Bottom+10);
                panel.Controls.Add(button);

                flowLayoutPanelVehicles.Controls.Add(panel);
            }
        }

        public AllCars(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            userButton.Text = employee.getUsername(); // dodaje ime ulogiranog korisnika na button
        }

        private void AllCars_Load(object sender, EventArgs e)
        {
            //spajanje na bazu podataka i kreiranje vozila
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String query = "select * from vozila";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())//dokle god postoji jos zapisa za procitati (nismo dosli do kraja)
                        {
                            vehicle = new Vehicle(
                                reader["naziv"].ToString(),
                                reader["marka"].ToString(),
                                reader["datumregistracije"].ToString(),
                                Convert.ToInt32(reader["brojkilometara"]),
                                Convert.ToInt32(reader["godiste"]),
                                reader["registracija"].ToString(),
                                Convert.ToInt32(reader["vrstagoriva"]),
                                Convert.ToSingle(reader["potrosnja"]),
                                Convert.ToInt32(reader["skupina"])
                            );
                            
                            listOfVehicles.Add(vehicle);
                            
                        }
                        foreach(Vehicle v in listOfVehicles)
                        {
                            Console.WriteLine(v);
                        }
                    }
                }
            }
            displayVehicles(listOfVehicles);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage(employee);
            homepage.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {

        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelVehicles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
