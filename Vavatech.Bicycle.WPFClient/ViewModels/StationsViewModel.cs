using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Region SelectedRegion { get; set; }

        public Station SelectedStation { get; set; }

        private IStationsService _Service;
        private IRegionsService _RegionService;

        public StationsViewModel()
            : this(new MockRegionsService(new MockStationsService()))
        {

        }
     

        public StationsViewModel(IRegionsService regionsService)
        {
            _RegionService = regionsService;

            SelectedRegion = _RegionService.Get(1);

        }


        #region

        private ICommand _ViewUsersCommand;

        public ICommand ViewUsersCommand
        {
            get
            {
                if (_ViewUsersCommand == null)
                {
                    _ViewUsersCommand = new RelayCommand(p => ViewUsers());
                }

                return _ViewUsersCommand;
            }
        }

        public void ViewUsers()
        {
            var usersView = new Views.UsersView();
            usersView.ShowDialog();
        }

        #endregion

        #region

        private ICommand _ViewBikesCommand;

        public ICommand ViewBikesCommand
        {
            get
            {
                if (_ViewBikesCommand == null)
                {
                    _ViewBikesCommand = new RelayCommand(p => ViewBikes());
                }

                return _ViewBikesCommand;
            }
        }

        public void ViewBikes()
        {
            var bikesView = new Views.BikesView();
            bikesView.ShowDialog();
        }

        #endregion

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

            SelectedRegion.Stations.Add(station);
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


        #region RemoveCommand

        private ICommand _RemoveCommand;

        public ICommand RemoveCommand
        {
            get
            {
                if (_RemoveCommand == null)
                {
                    _RemoveCommand = new RelayCommand(p=>Remove(), p => CanRemove);
                }

                return _RemoveCommand;
            }
        }

        private void Remove()
        {
            SelectedRegion.Stations.Remove(SelectedStation);
        }

        private bool CanRemove => SelectedStation != null;

        #endregion
    }
}
