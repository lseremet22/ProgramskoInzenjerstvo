using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    public class Reservation
    {
        private String OIB;
        private String typeOfReservation;
        private String registration;
        private int numberOfKilometers;
        private DateTime start;
        private DateTime end;
        private String name;
        private String surname;

        public Reservation(String OIB, String typeOfReservation, String registration, int numberOfKilometers, DateTime start, DateTime end, String name, String surname)
        {
            this.OIB = OIB;
            this.typeOfReservation = typeOfReservation;
            this.registration = registration;
            this.numberOfKilometers = numberOfKilometers;
            this.start = start;
            this.end = end;
            this.name = name;
            this.surname = surname;
        }

        //gettteri za dohvat vrijednosti svih elemenata
        public String getOIB()
        {
            return OIB;
        }

        public String getTypeOfReservation()
        {
            return typeOfReservation;
        }

        public String getRegistration()
        {
            return registration;
        }

        public int getNumberOfKilometers()
        {
            return numberOfKilometers;
        }

        public DateTime getStart()
        {
            return start;
        }

        public DateTime getEnd()
        {
            return end;
        }

        public String getName()
        {
            return name;
        }

        public String getSurname()
        {
            return surname;
        }
    }
}
