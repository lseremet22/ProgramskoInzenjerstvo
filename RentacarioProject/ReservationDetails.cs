using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentacarioProject
{
    public partial class ReservationDetails : Form
    {
        private Reservation reservation;
        private Employee employee;
        private int height;
        private int width;
        public ReservationDetails(int width, int height, Reservation reservation, Employee employee)
        {
            InitializeComponent();
            this.reservation = reservation;
            this.employee = employee;
        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 300);
            Label label = new Label();
            label.Text="OIB: "+ reservation.getOIB() + "\nRegistracija: " + reservation.getRegistration() +
                "\nPocetak: " + reservation.getStart() + "\nKraj: " + reservation.getEnd()
                + "\nIme: "+reservation.getName()
                + "\nPrezime: "+reservation.getSurname()
                + "\nBoj kilometaraa: "+ reservation.getNumberOfKilometers()
                + "\nVrsta rezervacije: "+reservation.getTypeOfReservation();
            label.AutoSize = true;
            label.Font = new Font("Arial", 14);

            Button button = new Button();
            button.Text = "Zatvori";
            button.Location = new Point((400-button.Width)/2,220);


            button.Click += (sender2, e2) =>
            {
                //ActiveReservations activeReservations = new ActiveReservations(employee, this.ClientSize.Width, this.ClientSize.Height);
                this.Hide();
                //activeReservations.Show();
            };
            
            this.Controls.Add(label);
            this.Controls.Add(button);
            button.BringToFront();
        }
    }
}
