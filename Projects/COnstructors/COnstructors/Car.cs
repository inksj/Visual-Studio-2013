using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COnstructors
{
    class Car{
        private float MSRP;
        private float invoice;
        private string make;
        private string model;
        private int year;
        private string VIN;

    
        public Car(float MSRP, float invoice, string make, string model, int year, string VIN)
        {
            this.MSRP = MSRP;
            this.invoice = invoice;
            this.make = make;
            this.model = model;
            this.year = year;
            this.VIN = VIN;
        
        }
    }
}
