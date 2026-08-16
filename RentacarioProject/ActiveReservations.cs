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
using System.Runtime.InteropServices;

namespace RentacarioProject
{
    public partial class ActiveReservations : Form
    {
        private int height;
        private int width;
        private Employee employee;

        private String connectionString =
        "Server=31.147.206.65;" +
        "Database=PI2526_lseremet22_DB;" +
        "User Id=PI2526_lseremet22;" +
        "Password=7*sW1R}.&7K)B-.);";

        public ActiveReservations(Employee employee, int height, int width)
        {
            InitializeComponent();
            this.employee = employee;
            this.height = height;
            this.width = width;
            userButton.Text = employee.getUsername();
        }

        private void AktivneRezervacije_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from rezervacije\r" +
                    "\nwhere sysdatetime()<=kraj\r\n" +
                    "and sysdatetime()>=pocetak;";

                using (SqlCommand command = new SqlCommand(query, connection)) 
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    { 
                        while (reader.Read())
                        {
                            //dio koji se dogodi za svaki redak koji se procita iz baze
                            Panel panel = new Panel();
                            panel.Size = new Size(400, 180);
                            panel.BorderStyle = BorderStyle.Fixed3D;

                            Label label = new Label();
                            label.Text = "registracija: " + reader["registracija"].ToString() +
                             "\nPocetak: " + reader["pocetak"].ToString() +
                             "\nKraj: " + reader["kraj"].ToString();
                            label.Location = new Point(10, 10);
                            label.AutoSize = true;
                            label.Font = new Font("Arial", 10);
                            panel.Controls.Add(label);

                            //dodavanje slike
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Image = Image.FromFile("C:\\Users\\lukas\\source\\repos\\lseremet22\\ProgramskoInzenjerstvo\\RentacarioProject\\Images\\ibizaEdited.png");
                            pictureBox.Location = new Point(label.Width + 15, 15);
                            pictureBox.Size = new Size(200, 120);
                            panel.Controls.Add(pictureBox);

                            //dodavanje gumba
                            Button button = new Button();
                            button.Text = "Detalji rezervacije";
                            button.Name = "button" + reader["registracija"].ToString();
                            button.Location = new Point((panel.Width - button.Width) / 2, pictureBox.Bottom + 10);
                            button.AutoSize = true;

                            /*button.Click += (sender, e) =>
                            {
                                this.Hide();
                                VehicleDetails vehicleDetails = new VehicleDetails(employee, this.ClientSize.Width, this.ClientSize.Height, v);
                                vehicleDetails.Show();
                            };*/

                            panel.Controls.Add(button);

                            flowLayoutPanel.Controls.Add(panel);

                        }
                        reader.Close();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage(employee, height, width);
            homepage.Show();
        }

        private void allCarsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllCars allCars = new AllCars(employee, height, width);
            allCars.Show();
        }

        private void availeableCarsButton_Click(object sender, EventArgs e)
        {

        }

        private void userButton_Click(object sender, EventArgs e)
        {

        }
    }
}
