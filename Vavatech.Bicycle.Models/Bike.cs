using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vavatech.Bicycle.Models
{
    public class Bike : Base
    {
        public int BikeId { get; set; }

        public string SerialNumber { get; set; }

        public BikeState State { get; set; }

    }
}
