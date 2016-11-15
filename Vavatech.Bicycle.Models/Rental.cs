using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Bicycle.Models
{
    public class Rental : Base
    {
        public int RentalId { get; set; }

        public Bike Bike { get; set; }

        public User Rentee { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public Station StationFrom { get; set; }

        public Station StationTo { get; set; }

        public decimal Cost { get; set; }
    }
}
