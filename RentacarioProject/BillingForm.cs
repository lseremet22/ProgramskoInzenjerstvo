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

        //Prazan konstruktor jer se designer u vscodeu nekad ne moze nositi s parametriziranim konstruktorom
        public BillingForm()
        {
            InitializeComponent();
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

            //textbox za stetu je defaultno disabled
            damagaField.Enabled = false;
        }

        private void damageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            damagaField.Enabled=true;

        }

        private void damagaField_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            float price = 0;
            FuelPriceRepository fuelRepo = new FuelPriceRepository();
            FuelPrice fuelPrice = fuelRepo.getFuelPrices();

            //provjerava koje gorivo je u pitanju
            if (u.getFuel() == "dizel"){
                price += (float.Parse(kilometersBox.Text) - u.getNumberOfKilometers())*(fuelPrice.getDiesel()*0.1f);
            }
            else
            {
                price += (float.Parse(kilometersBox.Text) - u.getNumberOfKilometers()) * fuelPrice.getGasoline() * 0.1f;
            }
            
            //provjerava postoji li steta
            if (damagaField.Enabled)
            {
                price += 500;
            }

            ammountLabel.Text = "Treba naplatiti: "+price.ToString();

        }

        private void billButton_Click(object sender, EventArgs e)
        {
            //azuriraj broj kilometara za vozilo u bazi
            VehicleRepository vehicleRepo = new VehicleRepository();
            vehicleRepo.editVehicleKilometers(u.getRegistration(), int.Parse((kilometersBox.Text).ToString()));

            //posalji email korisniku s podacima o naplati
            Billing billing = new Billing(damagaField.Text, u.getNumberOfKilometers(), int.Parse(kilometersBox.Text), u.getRegistration(), employee, float.Parse(ammountLabel.Text.Split(':')[1]));
            BillingRepository billingRepo = new BillingRepository();
            billingRepo.sendEmail(emailBox.Text, billing);
            
            //spremi podatke u tablicu naplata
            billingRepo.saveBillingData(billing);
        }
    }
}
