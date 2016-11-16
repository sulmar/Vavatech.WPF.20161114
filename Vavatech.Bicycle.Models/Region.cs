using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Bicycle.Models
{
    public class Region : Base
    {
        public int RegionId { get; set; }

        public string Name { get; set; }

        public IList<Station> Stations { get; set; }

        public int Capacity => Stations.Sum(s => s.Capacity);
    }
}
