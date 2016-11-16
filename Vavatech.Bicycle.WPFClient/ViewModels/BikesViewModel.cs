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
    public class BikesViewModel : BaseViewModel
    {
        public IList<Bike> Bikes { get; set; }

        public Bike SelectedBike { get; set; }

        private readonly IBikesService _Service;

        public BikesViewModel(IBikesService service)
        {
            _Service = service;

            Bikes = _Service.Get();
        }

        public BikesViewModel()
            : this(new MockBikesService())
        {
        }

    }
}
