using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public class Van:Vehicle
    {
        public Van(string registrationNumber, string make, string model, VehicleType vehicleType, Schedule schedule) : base(registrationNumber, make, model, vehicleType, schedule)
        {

        }

        public Van(string registrationNumber, string make, string model, VehicleType vehicleType) : base(registrationNumber, make, model, vehicleType)
        {

        }
    }
}
