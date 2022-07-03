using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public class Schedule:IOverlappable
    {
        private DateTime start;
        private DateTime finish;

        public Schedule(DateTime start, DateTime finish)
        {
            this.start = start.Date;
            this.finish = finish.Date;
        }

        public DateTime getStartDate()
        {
            return start.Date;
        }

        public DateTime getFinishDate()
        {
            return finish.Date;
        }

        public bool overlap(Schedule other)
        {
            if(other.getFinishDate()<this.getStartDate())
            {
                return true;
                
            }else if(other.getStartDate()>this.getFinishDate())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
