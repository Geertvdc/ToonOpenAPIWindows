using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "thermostatProgram")]
    public class ThermostatProgram : NotifyPropertyChanged
    {
        private Schedule[] _schedules;
        [DataMemberAttribute(Name = "schedules")]
        public Schedule[] Schedules
        {
            get { return _schedules; }
            set
            {
                if (_schedules != value)
                {
                    _schedules = value;
                    OnPropertyChanged("Schedules");
                }
            }
        }
    }
}
