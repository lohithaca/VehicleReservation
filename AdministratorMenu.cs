using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public class AdministratorMenu:RentalManager
    {
        private static AdministratorMenu am = new AdministratorMenu();
        public static void adminstratorMenuCall()
        {
            Console.WriteLine("Admin Menu");
            Console.WriteLine("Using this Admin Menu, You can");
            Console.WriteLine("1 - Add Vehicles to the System");
            Console.WriteLine("2 - Delet Vehicle from the System");
            Console.WriteLine("3 - List the available Vehicles");
            Console.WriteLine("4 - List the available Vehicles in Ordered");
            Console.WriteLine("5 - Generate Report");
            Console.WriteLine("6 - Customer Menu");
            Console.WriteLine("7 - Exit");

            int selection = Convert.ToInt32(Console.ReadLine());
     
                switch (selection)
            {
                case 1:
                    {
                        addvehicleCall();
                        break;
                    }
                case 2:
                    {
                        deleteVehicleCall();
                        break;
                    }
                case 3:
                    {
                        listVehicleCall();
                        break;
                    }
                case 4:
                    {
                        listVehicleOrderedCall();
                        break;
                    }
                case 5:
                    {
                        generateReportCall();
                        break;
                    }
                case 6:
                    {
                        CustomerMenu.customerMenuCall();
                        break;
                    }
                case 7:
                    {
                        break;
                    }
                default:
                    Console.WriteLine("Your Input is incorrect");
                    break;
            }
        }

        public static void addvehicleCall()
        {
            Console.WriteLine("Enter Vehicle registration Number");
            string inputVehicleNumber = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Make");
            string inputVehicleMake = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Model");
            string inputVehicleModel = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Model");
            string inputVehicleType = Console.ReadLine();

            am.addVehicle(new Vehicle(inputVehicleNumber, inputVehicleMake, inputVehicleModel, new VehicleType(inputVehicleType)));
            adminstratorMenuCall();
        }

        public static void deleteVehicleCall()
        {
            Console.WriteLine("Enter Vehicle registration Number");
            string inputVehicleNumber = Console.ReadLine();

            am.deleteVehicle(inputVehicleNumber);
            adminstratorMenuCall();
        }

        public static void listVehicleCall()
        {
            am.listVehicle();
            adminstratorMenuCall();
        }

        public static void listVehicleOrderedCall()
        {
            am.listVehicleOrdered();
            adminstratorMenuCall();
        }

        public static void generateReportCall()
        {
            Console.WriteLine("Enter the Report Name with extension");
            string inputReportName = Console.ReadLine();
            am.generateReport(inputReportName);
            adminstratorMenuCall();
        }
    }
}
