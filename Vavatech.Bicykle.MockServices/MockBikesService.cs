using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;

namespace Vavatech.Bicykle.MockServices
{
    public class MockBikesService : IBikesService
    {
        private readonly IList<Bike> _Bikes = new List<Bike>
        {
            new Bike { BikeId = 1, SerialNumber = "R001", State = BikeState.Ready },
            new Bike { BikeId = 2, SerialNumber = "R002", State = BikeState.Damaged },
            new Bike { BikeId = 3, SerialNumber = "R003", State = BikeState.Serviced },
        };

        public void Add(Bike item)
        {
            _Bikes.Add(item);
        }

        public Task AddAsync(Bike item)
        {
            throw new NotImplementedException();
        }

        public IList<Bike> Get()
        {
            return _Bikes;
        }

        public Bike Get(int itemId)
        {
            return _Bikes.Single(b => b.BikeId == itemId);
        }

        public Task<IList<Bike>> GetAsync()
        {
            return Task.Run(() => Get());
        }

        public Task<Bike> GetAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int itemId)
        {
            var bike = Get(itemId);

            _Bikes.Remove(bike);
        }

        public Task RemoveAsync(Bike item)
        {
            throw new NotImplementedException();
        }

        public void Update(Bike item)
        {
            var existsBike = Get(item.BikeId);

            existsBike = item;
        }

        public Task UpdateAsync(Bike item)
        {
            throw new NotImplementedException();
        }
    }
}
