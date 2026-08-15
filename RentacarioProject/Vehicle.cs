using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    public class Vehicle
    {
        private String model;
        private String brand;
        private String registrationDate;
        private int numberOfKilometers;
        private int yearOfProduction;
        private String registrationNumber;
        private int typeOfFuel;
        private float fuelConsumption;
        private int group;

        public Vehicle(String model, String brand, String registrationDate, int numberOfKilometers, int yearOfProduction, String registrationNumber, int typeOfFuel, float fuelConsumption, int group)
        {
            this.model = model;
            this.brand = brand;
            this.registrationDate = registrationDate;
            this.numberOfKilometers = numberOfKilometers;
            this.yearOfProduction = yearOfProduction;
            this.registrationNumber = registrationNumber;
            this.typeOfFuel = typeOfFuel;
            this.fuelConsumption = fuelConsumption;
            this.group = group;
        }

        public override string ToString()//koristi se samo za kontrolu, ne ispisuje se nigdje u formama i bazi
        {
            return model + " " + brand + " " + registrationDate + " " + numberOfKilometers + " " + yearOfProduction + " " + registrationNumber + " " + typeOfFuel + " " + fuelConsumption + " " + group;
        }


        //getteri za dohvat svih elemenata
        public String getModel()
        {
            return model;

        }

        public String getBrand()
        {
            return brand;
        }

        public String getRegistrationDate()
        {
            return registrationDate;
        }

        public int getNumberOfKilometers()
        {
            return numberOfKilometers;
        }

        public int getYearOfProduction()
        {
            return yearOfProduction;
        }

        public String getRegistrationNumber()
        {
            return registrationNumber;
        }

        public int getTypeOfFuel()
        {
            return typeOfFuel;
        }

        public float getFuelConsumption()
        {
            return fuelConsumption;
        }

        public int getGroup()
        {
            return group;
        }



    }
}
