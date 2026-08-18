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
    public partial class AddFuelPrice : Form
    {
        public AddFuelPrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sprema fuelprice u bazu
            float diesel = float.Parse(dieselBox.Text);
            float gas = float.Parse(gasBox.Text);
            DateTime uneseno = DateTime.Now;
            FuelPriceRepository fuelPriceRepository = new FuelPriceRepository();
            fuelPriceRepository.setFuelPrices(diesel, gas);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
