using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;

namespace Vavatech.Bicykle.MockServices
{
    public class MockRegionsService : IRegionsService
    {
        private IList<Region> _Regions = new List<Region>
        {
            new Region { RegionId = 1, Name = "Warszawa" }
        };

        public MockRegionsService(IStationsService stationsService)
        {
            
            _Regions.First().Stations = new ObservableCollection<Station>(stationsService.Get());
        }

        public void Add(Region item)
        {
            throw new NotImplementedException();
        }

        public IList<Region> Get()
        {
            return _Regions;
        }

        public Region Get(int itemId)
        {
            return _Regions.Single(r => r.RegionId == itemId);
        }

        public void Remove(int itemId)
        {
            throw new NotImplementedException();
        }

        public void Update(Region item)
        {
            throw new NotImplementedException();
        }
    }
}
