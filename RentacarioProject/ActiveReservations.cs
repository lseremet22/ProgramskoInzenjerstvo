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
        private ActiveReservationsRepository activeReservationsRepository;

        public ActiveReservations(Employee employee, int height, int width)
        {
            InitializeComponent();
            this.employee = employee;
            this.height = height;
            this.width = width;
            userButton.Text = employee.getUsername();
            this.activeReservationsRepository = new ActiveReservationsRepository();
        }

        private void AktivneRezervacije_Load(object sender, EventArgs e)
        {
            //sprema sve ucitane rezervacije u listu
            List<Reservation> reservations = new List<Reservation>();
            reservations = activeReservationsRepository.getActiveReservations();

            foreach (Reservation r in reservations) 
            {
                Panel panel = new Panel();
                panel.Size = new Size(400, 180);
                panel.BorderStyle = BorderStyle.Fixed3D;

                //kreiranje labele
                Label label = new Label();
                label.Text = "registracija: " + r.getRegistration().ToString() +
                 "\nPocetak: " + r.getStart().ToString() +
                 "\nKraj: " + r.getEnd().ToString();
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
                button.Name = "button" + r.getRegistration().ToString();
                button.Location = new Point((panel.Width - button.Width) / 2, pictureBox.Bottom + 10);
                button.AutoSize = true;

                button.Click += (sender2, e2) =>
                {
                    //this.Hide();
                    ReservationDetails reservationDetails = new ReservationDetails(width, height, r, employee);
                    reservationDetails.Show();
                };

                panel.Controls.Add(button);

                flowLayoutPanel.Controls.Add(panel);
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

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
