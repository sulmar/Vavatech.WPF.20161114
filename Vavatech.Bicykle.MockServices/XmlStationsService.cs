using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;

namespace Vavatech.Bicykle.MockServices
{
    public class XmlStationsService : IStationsService
    {
        private readonly string uri = "https://nextbike.net/maps/nextbike-official.xml";

        public XmlStationsService()
        {
        }

        public XmlStationsService(string uri)
        {
            this.uri = uri;
        }

        public void Add(Station item)
        {
            throw new NotSupportedException();
        }

        public IList<Station> Get()
        {
            throw new NotImplementedException();
        }

        public Station Get(int itemId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Station>> GetAsync()
        {
            string country = "Poland";
            string city = "Warszawa";

            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync(uri);
            }

            throw new NotImplementedException();
        }

        public void Remove(int itemId)
        {
            throw new NotSupportedException();
        }

        public void Update(Station item)
        {
            throw new NotSupportedException();
        }
    }
}
