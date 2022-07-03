using System;

namespace WesministerRentalVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object for Rental manager
            RentalManager RentalManager = new RentalManager();

            //creating vehicle customer object
            VehicleCustomer c1 = new VehicleCustomer();
            VehicleCustomer c2 = new VehicleCustomer();

            //creating vehicle type objects
            VehicleType Van = new VehicleType("Van");
            VehicleType Car = new VehicleType("Car");
            VehicleType ElectricCar = new VehicleType("ElectricCar");
            VehicleType Motorbike = new VehicleType("Motorbike");

            //creating date objects
            DateTime D1 = new DateTime(2022, 05, 01);
            DateTime D2 = new DateTime(2022, 05, 02);
            DateTime D3 = new DateTime(2022, 05, 04);
            DateTime D4 = new DateTime(2022, 05, 05);
            DateTime D5 = new DateTime(2022, 05, 06);
            DateTime D6 = new DateTime(2022, 05, 08);
            DateTime D7 = new DateTime(2022, 05, 09);
            DateTime D8 = new DateTime(2022, 05, 11);
            DateTime D9 = new DateTime(2022, 05, 12);
            DateTime D10 = new DateTime(2022, 05, 14);

            //creating schedule objects
            Schedule s1 = new Schedule(D1, D2);
            Schedule s2 = new Schedule(D2, D3);
            Schedule s3 = new Schedule(D2, D4);
            Schedule s4 = new Schedule(D1, D3);
            Schedule s5 = new Schedule(D4, D5);
            Schedule s6 = new Schedule(D5, D6);
            Schedule s7 = new Schedule(D4, D6);
            Schedule s8 = new Schedule(D5, D7);
            Schedule s9 = new Schedule(D4, D7);
            Schedule s10 = new Schedule(D5, D8);
            Schedule s11 = new Schedule(D6, D7);
            Schedule s12 = new Schedule(D6, D8);
            Schedule s13 = new Schedule(D7, D9);
            Schedule s14 = new Schedule(D8, D9);
            Schedule s15 = new Schedule(D9, D10);

            //creating vehicle objects
            Vehicle v1 = new Vehicle("kj5090", "Toyota", "allion", Van,s1);
            Vehicle v2 = new Vehicle("hw8241", "Nissan", "FB15",Car,s2);
            Vehicle v3 = new Vehicle("qa8069", "Nissan", "VAN",Car,s3);
            Vehicle v4 = new Vehicle("ka5023", "Mazda", "allion", Motorbike,s4);
            Vehicle v5 = new Vehicle("hg8200", "Nissan", "FB15", ElectricCar,s5);
            Vehicle v6 = new Vehicle("fr4878", "Mazda", "VAN", Car,s6);
            Vehicle v7 = new Vehicle("sd5002", "Toyota", "allion", Van,s7);
            Vehicle v8 = new Vehicle("50", "Mazda", "FB15", Motorbike);
            Vehicle v9 = new Vehicle("49-2340", "Nissan", "VAN", ElectricCar);
            Vehicle v10 = new Vehicle("99", "Toyota", "allion", Van);

            //Adding vehicles
            Console.WriteLine("Adding Vehicle to the Database");
            RentalManager.addVehicle(v1);
            RentalManager.addVehicle(v2);
            RentalManager.addVehicle(v3);
            RentalManager.addVehicle(v4);

            //Checking the duplication
            Console.WriteLine("Checking the Duplication");
            RentalManager.addVehicle(v4);

            RentalManager.addVehicle(v5);
            RentalManager.addVehicle(v6);
            RentalManager.addVehicle(v7);

            //Delete Vehicle
            RentalManager.deleteVehicle("qa8069");
            RentalManager.deleteVehicle("49-2340");

            RentalManager.addVehicle(v8);
            RentalManager.addVehicle(v9);
            RentalManager.addVehicle(v10);

            // Show the Customer menu 
            CustomerMenu.customerMenuCall();

        }
    }
}
