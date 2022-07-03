using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WesministerRentalVehicle
{
    public class RentalManager:VehicleList,IRentalVehicleManager
    {
        
        public bool addVehicle(Vehicle V)
        {
                bool vehicleRegistered = false;
                bool addvehicleOk = false;
            foreach (Vehicle vehicle in vehicleCollection)
            {
                if (vehicle.getRegistrationNumber().Equals(V.getRegistrationNumber()))
                {
                    vehicleRegistered = true;
                    addvehicleOk = false;
                    break;
                }
                
            }
                if (vehicleCollection.Count < 50 && !vehicleRegistered)
                {
                    vehicleCollection.Add(V);
                    Console.WriteLine("The Vehicle has succefuly added to the System -" + V.getRegistrationNumber());
                    Console.WriteLine("Available Parking Slot " + (50 - vehicleCollection.Count));
                    Console.WriteLine();
                    addvehicleOk= true;
                }
                else
                {
                    Console.WriteLine("This vehicle has already registered");
                    addvehicleOk = false;
                }
           return addvehicleOk;
        }

        public bool deleteVehicle(string RegistrationNumber)
        {
            int i = 0;
            bool deleteOk = false;
           foreach (Vehicle vehicle in vehicleCollection)
            {
                if (vehicle.getRegistrationNumber().Equals(RegistrationNumber))
                {
                    Console.WriteLine("The details of the Delet Vehicle ");
                    Console.WriteLine("Registration Number "+vehicleCollection[i].getRegistrationNumber());
                    Console.WriteLine("Make " + vehicleCollection[i].getMake());
                    Console.WriteLine("Model " + vehicleCollection[i].getModel());
                    vehicleCollection.RemoveAt(i);
                    deleteOk = true;
                    Console.WriteLine("Available Number of Vehicles are "+vehicleCollection.Count);
                    Console.WriteLine();
                 
                    break;
                }
                i++;
            }
           return deleteOk;
        }

        public void listVehicle()
        {
            foreach (Vehicle vehicle in vehicleCollection)
            {
                Console.WriteLine("Registration Number -"+vehicle.getRegistrationNumber());
                Console.WriteLine("Type -"+vehicle.getVehicleType().getTypeName());
                Console.WriteLine("Model -"+vehicle.getModel());
                Console.WriteLine("Make -"+vehicle.getMake());
                foreach(Schedule schedule in vehicle.getSchedule())
                    Console.WriteLine("Start - "+schedule.getStartDate().ToString("d") + "Finish - "+schedule.getFinishDate().ToString("d"));
                Console.WriteLine();
            }
        }

        public void listVehicleOrdered()
        {
            vehicleCollection.Sort();
            foreach (Vehicle vehicle in vehicleCollection)
            {
                Console.WriteLine("Registration Number -" + vehicle.getRegistrationNumber());
                Console.WriteLine("Type -" + vehicle.getVehicleType().getTypeName());
                Console.WriteLine("Model -" + vehicle.getModel());
                Console.WriteLine("Make -" + vehicle.getMake());
                foreach (Schedule schedule in vehicle.getSchedule())
                    Console.WriteLine("Start - " + schedule.getStartDate().ToString("d") + "Finish - " + schedule.getFinishDate().ToString("d"));
                Console.WriteLine();
            }
        }

        public void generateReport(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);

            foreach (Vehicle vehicle in vehicleCollection)
            {
                writer.WriteLine("Registration Number -"+vehicle.getRegistrationNumber());
                writer.WriteLine("Model -"+vehicle.getModel());
                writer.WriteLine("Type -" + vehicle.getVehicleType().getTypeName());
                writer.WriteLine("Make -"+vehicle.getMake());
                foreach (Schedule schedule in vehicle.getSchedule())
                    writer.WriteLine("Start - " + schedule.getStartDate().ToString("d") + "Finish - " + schedule.getFinishDate().ToString("d"));
                writer.WriteLine();
            }
       
            writer.Dispose();
        }

    }
}
