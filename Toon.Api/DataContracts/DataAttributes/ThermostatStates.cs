using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "thermostatStates")]
    public class ThermostatStates : NotifyPropertyChanged
    {
        private State[] _states;
        [DataMemberAttribute(Name = "state")]
        public State[] States
        {
            get { return _states; }
            set
            {
                if (_states != value)
                {
                    _states = value;
                    OnPropertyChanged("States");
                }
            }
        }
    }
}
