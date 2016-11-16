using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Bicycle.Models
{
    public class Station : Base
    {
        public int StationId { get; set; }

        #region Number

        private string _Number;
        public string Number
        {
            get
            {
                return _Number;
            }

            set
            {
                _Number = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        #endregion
        public Location Location { get; set; }

        public string Address { get; set; }

        public short Capacity { get; set; }

        public string FullName => $"{Number} - {Address}";

        public override string ToString() => Number;
    }
}
