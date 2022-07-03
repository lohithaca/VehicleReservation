using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public interface IRentVehicleCustomer
    {
        public void listAvailableVehicle(VehicleType wantedType, Schedule wantedSchedule);
        public bool rentVehicle(string RegistrationNumber, Schedule wantedSchedule);
    }
}
