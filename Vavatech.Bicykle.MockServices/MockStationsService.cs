using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;

namespace Vavatech.Bicykle.MockServices
{
    public class MockStationsService : IStationsService
    {
        private static IList<Station> _Stations = new List<Station>
        {
            new Station
            {
                StationId = 1,
                Number = "ST001",
                Capacity = 10,
                Address = "ul. Olesińska 18",
                Location = new Location { Latitude = 52.3, Longitude = 18.5  },
            },

            new Station
            {
                StationId = 2,
                Number = "ST002",
                Capacity = 15,
                Address = "ul. Puławska 100",
                Location = new Location { Latitude = 52.67, Longitude = 18.6  },
            },

            new Station
            {
                StationId = 3,
                Number = "ST003",
                Capacity = 20,
                Address = "Aleje Jerozolimskie 200",
                Location = new Location { Latitude = 53.3, Longitude = 19.5  },
            },
        };


        public void Add(Station station)
        {
            _Stations.Add(station);
        }

        public IList<Station> Get()
        {
            return _Stations;
        }

        public Station Get(int stationId)
        {
            return _Stations.Single(s => s.StationId == stationId);
        }

        public void Remove(int stationId)
        {
            var station = Get(stationId);

            _Stations.Remove(station);
        }

        public void Update(Station station)
        {
            var existsStation = Get(station.StationId);

            existsStation = station;
        }

        public void DisplayMap()
        {

        }
    }
}
