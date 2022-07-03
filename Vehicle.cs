using System;
using System.Collections.Generic;
using System.Text;


namespace WesministerRentalVehicle
{
    public class Vehicle : IComparable<Vehicle>
    {
        private string registrationNumber;
        private string make;
        private string model;
        private VehicleType vehicleType;
        private List<Schedule> schedule = new List<Schedule>();
        
        public Vehicle(string registrationNumber, string make, string model, VehicleType vehicleType, Schedule schedule)
        {
                this.registrationNumber = registrationNumber;
                this.make = make;
                this.model = model;
                this.vehicleType = vehicleType;
                this.schedule.Add(schedule);
        }

        public Vehicle(string registrationNumber, string make, string model, VehicleType vehicleType)
        {
            this.registrationNumber = registrationNumber;
            this.make = make;
            this.model = model;
            this.vehicleType = vehicleType;
            //this.schedule.Add(new Schedule(DateTime.Today,DateTime.Today));
        }

        public string getRegistrationNumber()
        {
            return registrationNumber;
        }

        public string getMake()
        {
            return make;
        }

        public string getModel()
        {
            return model;
        }

        public List<Schedule> getSchedule()
        {
            return schedule; 
        }
               
        public VehicleType getVehicleType()
        {
            return vehicleType;
        }

        public void setSchedule(Schedule newSchedule)
        {
            this.schedule.Add(newSchedule);
            
        }

        public int CompareTo(Vehicle other)
        {
            return string.Compare(make, other.make);
        }
        
        
    }
}
