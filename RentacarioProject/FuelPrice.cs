using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarioProject
{
    public class FuelPrice
    {
        private float diesel;
        private float gasoline;
        private DateTime uneseno;

        public FuelPrice(float diesel, float gasoline, DateTime uneseno)
        {
            this.diesel = diesel;
            this.gasoline = gasoline;
            this.uneseno = uneseno;
        }

        public float getDiesel()
        {
            return diesel;
        }

        public float getGasoline()
        {
            return gasoline;
        }

        public DateTime getUneseno()
        {
            return uneseno;
        }
    }
}
