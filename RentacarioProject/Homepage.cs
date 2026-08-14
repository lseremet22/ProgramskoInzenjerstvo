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
    public partial class Homepage : Form
    {
        private Employee employee;
        public Homepage(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            //userlabel.Text = employee.ToString();
        }
    }
}
