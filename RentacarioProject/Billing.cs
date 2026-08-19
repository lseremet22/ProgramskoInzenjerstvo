using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    public class Billing
    {
        private String damage;
        private int oldKilometers;
        private int newKilometers;
        private String registration;
        private Employee employee;
        private float ammount;

        public Billing(String damage, int oldKilometers, int newKilometers, String registration, Employee employee, float ammount)
        {
            this.damage = damage;
            this.oldKilometers= oldKilometers;
            this.newKilometers = newKilometers;
            this.registration = registration;
            this.employee = employee;
            this.ammount = ammount;
        }

        public String getDamage() { return damage; }
        public int getOldKilometers() { return oldKilometers; }
        public int getNewKilometers() {return newKilometers; }
        public String getRegistration() { return registration; }
        public Employee getEmployee() { return employee; }
        public float getAMmount() { return ammount; }

    }
}
