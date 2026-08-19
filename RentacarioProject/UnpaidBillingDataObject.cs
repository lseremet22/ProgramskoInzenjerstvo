using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    //klasa koja pomaze u prenosenju podataka izmedu repozitorija i forme
    public class UnpaidBillingDataObject
    {
        private String name;
        private String surname;
        private String oib;
        private DateTime end;
        private String maker;
        private String model;
        private String registration;
        private int numberOfKilometers;
        private String fuel;

        public UnpaidBillingDataObject(string name, string surname, string oib, DateTime end, string maker, string model, string registration, int numberOfKilometers, string fuel)
        {
            this.name = name;
            this.surname = surname;
            this.oib = oib;
            this.end = end;
            this.maker = maker;
            this.model = model;
            this.registration = registration;
            this.numberOfKilometers = numberOfKilometers;
            this.fuel = fuel;
        }

        public String getName() { return name; }
        public String getSurname() { return surname; }
        public String getOib() { return oib; }
        public DateTime getEnd() { return end; }    
        public String getMaker() { return maker; }  
        public String getModel() { return model; }
        public String getRegistration() { return registration; }
        public int getNumberOfKilometers() { return numberOfKilometers; }
        public String getFuel() { return fuel; }
    }
}
