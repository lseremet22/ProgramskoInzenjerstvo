using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    public class Service
    {
        private DateTime start;
        private DateTime end;
        private String registration;
        private int numberOfKilometers;

        public Service(DateTime start, DateTime end, String registration, int numberOfKilometers) {
            this.start = start;
            this.end = end;
            this.registration = registration;
            this.numberOfKilometers = numberOfKilometers;
        }

        public DateTime getStart()
        {
            return start;
        }

        public DateTime getEnd()
        {
            return end;
        }

        public String getRegistration() {
            return registration;
        }

        public int getNumberOfKilometers()
        {
            return numberOfKilometers;
        }

    }
}
