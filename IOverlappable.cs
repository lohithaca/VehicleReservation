using System;
using System.Collections.Generic;
using System.Text;

namespace WesministerRentalVehicle
{
    public interface IOverlappable
    {
        public bool overlap(Schedule other);
    }
}
