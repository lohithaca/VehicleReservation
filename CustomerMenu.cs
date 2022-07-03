using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public class CustomerMenu:VehicleCustomer
    
    {
        private static CustomerMenu cm = new CustomerMenu();
        public static void customerMenuCall()
        {
            Console.WriteLine("Customer Menu");
            Console.WriteLine("Using this Customer Menu, You can");
            Console.WriteLine("1 - List Available Vehicle");
            Console.WriteLine("2 - Rent a Vehicle");
            Console.WriteLine("3 - Admin Menu");
            Console.WriteLine("4 - Exit");
            Console.WriteLine();
            Console.WriteLine("Type the Number to proceed");

            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    {
                        listAvailableVehicleCall();
                    }
                    break;
                case 2:
                    {
                        rentVehicleCall();
                    }
                    break;
                case 3:
                    AdministratorMenu.adminstratorMenuCall();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Your Input is incorrect");
                    break;
            }
        }
        public static void listAvailableVehicleCall()
        {
            Console.WriteLine("Enter your prefered type");
            string inputVehicleType = Console.ReadLine();
            Console.WriteLine("Enter trip Start Date (yyyy, mm, dd) format");
            DateTime inputStart = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter trip Finish Date (yyyy, mm, dd) format");
            DateTime inputFinish = Convert.ToDateTime(Console.ReadLine());

            cm.listAvailableVehicle(new VehicleType(inputVehicleType), new Schedule(inputStart, inputFinish));
            customerMenuCall();
        }

        public static void rentVehicleCall()
        {
            bool rentVehicle = false;
            Console.WriteLine("Enter vehicle Registration Number");
            string inputVehicleNumber = Console.ReadLine();
            Console.WriteLine("Enter trip Start Date (yyyy, mm, dd) format");
            DateTime inputStart = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter trip Finish Date (yyyy, mm, dd) format");
            DateTime inputFinish = Convert.ToDateTime(Console.ReadLine());

            Schedule sc1 = new Schedule(inputStart, inputFinish);
            rentVehicle = cm.rentVehicle(inputVehicleNumber, sc1);
            customerMenuCall();

        }
        
    }
}
