﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Bicycle.Models
{
    public class Location : Base
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public override string ToString() => $"lat: {Latitude} lng: {Longitude}";
    }
}
