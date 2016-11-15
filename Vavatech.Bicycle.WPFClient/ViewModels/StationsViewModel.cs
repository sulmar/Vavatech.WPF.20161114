using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;
using Vavatech.Bicykle.MockServices;

namespace Vavatech.Bicycle.WPFClient.ViewModels
{
    public class StationsViewModel : BaseViewModel
    {
        public IList<Station> Stations { get; set; }

        public Station SelectedStation { get; set; }

        private IStationsService _Service;


        public StationsViewModel()
            : this(new MockStationsService())
        {
        }

        public StationsViewModel(IStationsService stationsService)
        {
            _Service = stationsService;

            Stations = _Service.Get();

            SelectedStation = Stations.Last();
        }
    }
}
