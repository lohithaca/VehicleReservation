using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public class VehicleType
    {
        private string type;

        public VehicleType(string type)
        {
            this.type = type;
        }
        public string getTypeName()
        {
            return type;
        }
    }

        
}
