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
    public partial class VehicleDetails : Form
    {
        private String connectionString =
        "Server=31.147.206.65;" +
        "Database=PI2526_lseremet22_DB;" +
        "User Id=PI2526_lseremet22;" +
        "Password=7*sW1R}.&7K)B-.);";

        private Employee employee;
        private int height;
        private int width;
        private Vehicle v;
        public VehicleDetails(Employee employee, int height, int width, Vehicle v)
        {
            InitializeComponent();
            this.employee = employee;
            this.height = height;
            this.width = width;
            this.v = v;
            //this.Size = new Size(width, height);
            userButton.Text = employee.getUsername();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VehicleDetails_Load(object sender, EventArgs e)
        {
            //prikaz podataka o vozilu
            Panel panel = new Panel();
            panel.Size = new Size(flowLayoutPanel.Width, flowLayoutPanel.Height);
            Label label = new Label();
            label.Text = "Marka: " + v.getBrand() + "\nModel: " + v.getModel()
                + "\nDatum registracije: " + v.getRegistrationDate() + "\nBroj kilometara: " + v.getNumberOfKilometers()
                + "\nGodiste: " + v.getYearOfProduction() + "\nRegistracija: " + v.getRegistrationNumber()
                + "\nVrsta goriva: " + v.getTypeOfFuel() + "\nPotrošnja: " + v.getFuelConsumption() + "\nVrsta vozila: " + v.getGroup();
            label.Location = new Point(10, 10);
            label.AutoSize = true;
            label.Font = new Font("Arial", 14);
            panel.Controls.Add(label);

            //dodavanje slike
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("C:\\Users\\lukas\\source\\repos\\lseremet22\\ProgramskoInzenjerstvo\\RentacarioProject\\Images\\ibizaEdited.png");
            pictureBox.Location = new Point(label.Width +40, 15);
            //pictureBox.Size = new Size(label.Height, (int)(label.Height*0.6));
            pictureBox.Size = new Size((int)(panel.Width*0.4), (int)((panel.Width)*0.25));
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.Controls.Add(pictureBox);

            flowLayoutPanel.Controls.Add(panel);
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage(employee, height, width);
            homepage.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati ovo vozilo?", 
                "Potvrdi brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
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
                this.Hide();
                AllCars allCars = new AllCars(employee, height, width);
                allCars.Show();
            }

            //ako nije potvrđeno nece se dogoditi nista
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle editVehicle = new EditVehicle(employee, height, width, v);
            editVehicle.Show();
        }
    }
}
