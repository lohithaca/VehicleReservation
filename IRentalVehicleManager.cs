using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public interface IRentalVehicleManager
    {
        public bool addVehicle(Vehicle V);
        public bool deleteVehicle(string RegistrationNumber);
        public void listVehicle();
        public void listVehicleOrdered();
        public void generateReport(string fileName);
    }
}
