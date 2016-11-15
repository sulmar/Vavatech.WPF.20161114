using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;
using Vavatech.Bicycle.WPFClient.Commands;
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
        }

        #region AddCommand

        private ICommand _AddCommand;

        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand==null)
                {
                    _AddCommand = new RelayCommand(p => Add());
                }

                return _AddCommand;
            }
        }

        public void Add()
        {
            // TODO: Wyświetlić okno do dodawania stacji

            var station = new Station { StationId = 10, Number = "ST 100", Capacity = 20 };

            Stations.Add(station);
        }

        #endregion

        #region UpdateCommand

        private ICommand _UpdateCommand;

        public ICommand UpdateCommand
        {
            get
            {
                if (_UpdateCommand==null)
                {
                    _UpdateCommand = new RelayCommand(p=>UpdateStation(), p=>CanUpdateStation());
                }

                return _UpdateCommand;
            }
        }

        public void UpdateStation()
        {
            SelectedStation.Number = "ST 100";
        }

        public bool CanUpdateStation()
        {
            return SelectedStation!=null && SelectedStation.Capacity > 14;
        }

        #endregion
    }
}
