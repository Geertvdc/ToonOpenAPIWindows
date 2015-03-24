using Newtonsoft.Json;
using System.Runtime.Serialization;
using Toon.Api.Enums;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "state")]
    public class State : NotifyPropertyChanged
    {
        private ThermostatState _thermostatState;
        [JsonProperty("id")]
        [JsonConverter(typeof(ThermostatStateEnumConverter))]
        public ThermostatState ThermostatState
        {
            get { return _thermostatState; }
            set
            {
                if (_thermostatState != value)
                {
                    _thermostatState = value;
                    OnPropertyChanged("ThermostatState");
                }
            }
        }

        private int _tempValue;
        [DataMemberAttribute(Name = "tempValue")]
        public int Temperature
        {
            get { return _tempValue; }
            set
            {
                if (_tempValue != value)
                {
                    _tempValue = value;
                    OnPropertyChanged("Temperature");
                }
            }
        }

        private int _dhw;
        [DataMemberAttribute(Name = "dhw")]
        public int Dhw
        {
            get { return _dhw; }
            set
            {
                if (_dhw != value)
                {
                    _dhw = value;
                    OnPropertyChanged("Dhw");
                }
            }
        }
    }
}
