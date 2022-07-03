using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public class VehicleCustomer:VehicleList,IRentVehicleCustomer
    {
        public void listAvailableVehicle(VehicleType wantedType, Schedule wantedSchedule)
        {
            
                for (int i = 0; i < vehicleCollection.Count; i++)
                {
                    if (vehicleCollection[i].getVehicleType().getTypeName().Equals(wantedType.getTypeName()))
                    {

                    bool availableVehicle = true;
                    for(int j = 0; j < vehicleCollection[i].getSchedule().Count; j++)
                       {
                            if (!wantedSchedule.overlap(vehicleCollection[i].getSchedule()[j]))
                            {
                                availableVehicle = false;
                                break;
                            }
                        }
                    if(availableVehicle)
                        {
                        Console.WriteLine("Registration Number -" + vehicleCollection[i].getRegistrationNumber());
                        Console.WriteLine("Type -" + vehicleCollection[i].getVehicleType().getTypeName());
                        Console.WriteLine("Model -" + vehicleCollection[i].getModel());
                        Console.WriteLine("Make -" + vehicleCollection[i].getMake());
                        foreach (Schedule schedule in vehicleCollection[i].getSchedule())
                            Console.WriteLine("Start - " + schedule.getStartDate().ToString("d") + "Finish - " + schedule.getFinishDate().ToString("d"));
                        Console.WriteLine();
                        }
                    }
                }
        }

        public bool rentVehicle(string RegistrationNumber, Schedule wantedSchedule)
        {
            bool setScheduleOk = false;
            for (int i = 0; i < vehicleCollection.Count; i++)
            {
                if (vehicleCollection[i].getRegistrationNumber().Equals(RegistrationNumber))
                {
                    for (int j = 0; j < vehicleCollection[i].getSchedule().Count; j++)
                    {
                        if (!wantedSchedule.overlap(vehicleCollection[i].getSchedule()[j]))
                        {
                            setScheduleOk = false;
                            break;
                        }
                        else
                        {
                            setScheduleOk = true;
                        }
                    }
                    if (setScheduleOk)
                    {
                        vehicleCollection[i].setSchedule(wantedSchedule);
                    }
                }
            }
            return setScheduleOk;
        }

    }
}
