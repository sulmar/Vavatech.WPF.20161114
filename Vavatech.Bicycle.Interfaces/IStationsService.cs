using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vavatech.Bicycle.Models;

namespace Vavatech.Bicycle.Interfaces
{
    public interface IStationsService
    {
        IList<Station> Get();

        Station Get(int stationId);

        void Add(Station station);

        void Update(Station station);

        void Remove(int stationId);
    }
}
