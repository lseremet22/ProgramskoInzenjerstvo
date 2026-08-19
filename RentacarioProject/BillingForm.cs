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
        public BillingForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
