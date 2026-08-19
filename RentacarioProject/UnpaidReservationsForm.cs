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
    public partial class UnpaidReservationsForm : Form
    {
        private BillingRepository billingRepository;
        Employee employee;
        public UnpaidReservationsForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.billingRepository = new BillingRepository();
        }

        private void UnpaidReservationsForm_Load(object sender, EventArgs e)
        {
            List<UnpaidBillingDataObject> list = new List<UnpaidBillingDataObject>();
            list = billingRepository.getUnpaidBillingData();

            foreach (UnpaidBillingDataObject u in list)
            {
                Panel panel = new Panel();
                panel.Size = new Size(400, 180);
                panel.BorderStyle = BorderStyle.Fixed3D;

                //kreiranje labele
                Label label = new Label();
                label.Text = "Ime: " + u.getName()+
                    "\nPrezime: "+u.getSurname()+
                    "\nOIB: "+u.getOib()+
                    "\nKraj: "+u.getEnd()+
                    "\nMarka: "+u.getMaker()+
                    "\nModel: "+u.getModel()+
                    "\nRegistracija: "+u.getRegistration();
                
                label.Location = new Point(10, 10);
                label.AutoSize = true;
                label.Font = new Font("Arial", 10);
                panel.Controls.Add(label);

                Button billButton = new Button();
                billButton.Text = "Naplati";
                billButton.Location = new Point(label.Width+20, 70);
                panel.Controls.Add(label);
                panel.Controls.Add(billButton);
                flowLayoutPanel.Controls.Add(panel);

                //funkcionalnost gumbica za naplatu
                billButton.Click += (sender2, e2) =>
                {
                    BillingForm form = new BillingForm(employee);
                    form.Show();
                };

            }
        }
    }
}
