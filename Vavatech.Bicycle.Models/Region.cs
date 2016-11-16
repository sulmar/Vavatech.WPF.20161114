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

        #region Stations

        private IList<Station> _Stations;
        public IList<Station> Stations
        {
            get
            {
                return _Stations;
            }

            set
            {
                _Stations = value;

                OnPropertyChanged();

                OnStationsChanged();
            }
        }

        private void OnStationsChanged()
        {
            // Podpinamy się pod obiekty stacji
            foreach (var station in _Stations)
            {
                station.PropertyChanged += Station_PropertyChanged;
            }
        }

        private void Station_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName==nameof(Station.Capacity))
            {
                OnPropertyChanged(nameof(Capacity));
            }
        }

        #endregion

        public int Capacity => Stations.Sum(s => s.Capacity);
    }
}
