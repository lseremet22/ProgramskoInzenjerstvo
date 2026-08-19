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
    public partial class BillingForm : Form
    {
        private Employee employee;
        private UnpaidBillingDataObject u;
        public BillingForm(Employee employee, UnpaidBillingDataObject u)
        {
            InitializeComponent();
            this.employee = employee;
            this.u=u;
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text=u.getName();
            surnameLabel.Text=u.getSurname();
            OIBLabel.Text = u.getOib();
            endPeriodLabel.Text = u.getEnd().ToString();
            makerLabel.Text = u.getMaker();
            modelLabel.Text = u.getModel();
            registrationLabel.Text = u.getRegistration();
            fuelLabel.Text = u.getFuel();
        }
    }
}
