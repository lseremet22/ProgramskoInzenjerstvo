using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentacarioProject
{
    public partial class Homepage : Form
    {

        private String connectionString =
        "Server=31.147.206.65;" +
        "Database=PI2526_lseremet22_DB;" +
        "User Id=PI2526_lseremet22;" +
        "Password=7*sW1R}.&7K)B-.);";

        private Employee employee;

        //parametri koji cuvaju da novi proyor bude jednako velik ko stari
        private int height;
        private int width;

        private Vehicle vehicle;
        private List<Vehicle> listOfVehicles = new List<Vehicle>();

        private void displayVehiclesToService(List<Vehicle> listOfVehicles)
        {
            flowLayoutPanelVehicles.Controls.Clear();

            foreach (Vehicle v in listOfVehicles)
            {
                Panel panel = new Panel();
                panel.Size = new Size(400, 180);
                panel.BorderStyle = BorderStyle.Fixed3D;

                //dodavanje podataka
                Label label = new Label();
                label.Text = "Potrebno servisirati!"+
                    "\nMarka: " + v.getBrand() + "\nModel: " + v.getModel()
                    + "\nDatum registracije: " + v.getRegistrationDate() + "\nRegistracija: " + v.getRegistrationNumber();
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
                button.Text = "Pošalji na servis";
                button.AutoSize = true;
                button.Name = "button" + v.getRegistrationNumber();
                button.Location = new Point((panel.Width - button.Width) / 2, pictureBox.Bottom + 10);

                //funkcija buttona za slanje vozila na servis
                button.Click += (sender2, e2) =>
                {
                    DialogResult = MessageBox.Show("Jeste li sigurni da želite poslati vozilo na servis?",
                        "Potvrdi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


                    if (DialogResult== DialogResult.Yes)
                    {
                        //sprema detalje o servisu u bazu
                        ServiceRepository serviceRepository = new ServiceRepository();
                        serviceRepository.sendToService(v);
                    }
               
                };

                panel.Controls.Add(button);

                flowLayoutPanelVehicles.Controls.Add(panel);
            }
        }

        public Homepage(Employee employee, int width, int height)
        {
            InitializeComponent();
            this.width = width;
            this.height = height;
            this.employee = employee;
            //userButton.Text = employee.getUsername();
            if(employee.getPosition() == 1)
            {
                userButton.Enabled = false;
            }
            this.Size = new Size(width, height);
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        private void allCarsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllCars allcars = new AllCars(employee,this.ClientSize.Width,this.ClientSize.Height);
            allcars.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            
            //spajanje na bazu podataka i kreiranje vozila
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String query = "SELECT \r\nvozila.naziv,\r\nvozila.marka,\r\nvozila.datumregistracije,\r\nvozila.brojkilometara," +
                    "\r\nvozila.godiste,\r\nvozila.registracija,\r\nvrstegoriva.nazivgoriva AS vrstagoriva,\r\nvozila.potrosnja," +
                    "\r\nskupine.nazivskupine AS skupina\r\nFROM vozila\r\nJOIN skupine\r\n    " +
                    "ON vozila.skupina = skupine.IDskupine\r\nJOIN vrstegoriva\r\n    " +
                    "ON vozila.vrstagoriva = vrstegoriva.IDgoriva" +
                    " WHERE datumregistracije <= DATEADD(MONTH, -11, GETDATE());";

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
                                reader["vrstagoriva"].ToString(),
                                Convert.ToSingle(reader["potrosnja"]),
                                reader["skupina"].ToString()
                            );

                            listOfVehicles.Add(vehicle);

                        }
                        foreach (Vehicle v in listOfVehicles)
                        {
                            Console.WriteLine(v);
                        }
                    }
                }
            }
            displayVehiclesToService(listOfVehicles);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {
            ActiveReservations activeReservations = new ActiveReservations(employee, this.ClientSize.Width, this.ClientSize.Height);
            this.Hide();
            activeReservations.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            //unos cijene goriva
            AddFuelPrice addFuelPrice = new AddFuelPrice();
            addFuelPrice.Show();

        }
    }
}
