using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using Toon.Api.Enums;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "thermostatInfo")]
    public class ThermostatInfo : CacheEntity
    {
        private double _currentTemp;
        [DataMemberAttribute(Name = "currentTemp")]
        public double CurrentTemp
        {
            get { return _currentTemp; }
            set
            {
                if (_currentTemp != value)
                {
                    _currentTemp = value;
                    OnPropertyChanged("CurrentTemp");
                }
            }
        }

        private double _currentSetpoint;
        [DataMemberAttribute(Name = "currentSetpoint")]
        public double CurrentSetpoint
        {
            get { return _currentSetpoint; }
            set
            {
                if (_currentSetpoint != value)
                {
                    _currentSetpoint = value;
                    OnPropertyChanged("CurrentSetpoint");
                }
            }
        }

        private double _currentDisplayTemp;
        [DataMemberAttribute(Name = "currentDisplayTemp")]
        public double CurrentDisplayTemperature
        {
            get { return _currentDisplayTemp; }
            set
            {
                if (_currentDisplayTemp != value)
                {
                    _currentDisplayTemp = value;
                    OnPropertyChanged("CurrentDisplayTemperature");
                }
            }
        }

        private ProgramState _programState;
        [JsonProperty("programState")]
        [JsonConverter(typeof(ProgramStateEnumConverter))]
        public ProgramState ProgramState
        {
            get { return _programState; }
            set
            {
                if (_programState != value)
                {
                    _programState = value;
                    OnPropertyChanged("ProgramState");
                }
            }
        }

        private ThermostatState _activeState;
        [JsonProperty("activeState")]
        [JsonConverter(typeof(ThermostatStateEnumConverter))]
        public ThermostatState ActiveState
        {
            get { return _activeState; }
            set
            {
                if (_activeState != value)
                {
                    _activeState = value;
                    OnPropertyChanged("ActiveState");
                }
            }
        }

        private ProgramState _nextProgram;
        [JsonProperty("nextProgram")]
        [JsonConverter(typeof(ProgramStateEnumConverter))]
        public ProgramState NextProgram
        {
            get { return _nextProgram; }
            set
            {
                if (_nextProgram != value)
                {
                    _nextProgram = value;
                    OnPropertyChanged("NextProgram");
                }
            }
        }

        private ThermostatState _nextState;
        [JsonProperty("nextState")]
        [JsonConverter(typeof(ThermostatStateEnumConverter))]
        public ThermostatState NextState
        {
            get { return _nextState; }
            set
            {
                if (_nextState != value)
                {
                    _nextState = value;
                    OnPropertyChanged("NextState");
                }
            }
        }

        private double _nextTime;
        [DataMemberAttribute(Name = "nextTime")]
        public double NextTime
        {
            get { return _nextTime; }
            set
            {
                if (_nextTime != value)
                {
                    _nextTime = value;
                    OnPropertyChanged("NextTime");
                }
            }
        }

        private double _nextSetpoint;
        [DataMemberAttribute(Name = "nextSetpoint")]
        public double NextSetpoint
        {
            get { return _nextSetpoint; }
            set
            {
                if (_nextSetpoint != value)
                {
                    _nextSetpoint = value;
                    OnPropertyChanged("NextSetpoint");
                }
            }
        }

        private double _randomConfigId;
        [DataMemberAttribute(Name = "randomConfigId")]
        public double RandomConfigId
        {
            get { return _randomConfigId; }
            set
            {
                if (_randomConfigId != value)
                {
                    _randomConfigId = value;
                    OnPropertyChanged("RandomConfigId");
                }
            }
        }

        private double _errorFound;
        [DataMemberAttribute(Name = "errorFound")]
        public double ErrorFound
        {
            get { return _errorFound; }
            set
            {
                if (_errorFound != value)
                {
                    _errorFound = value;
                    OnPropertyChanged("ErrorFound");
                }
            }
        }

        private double _zwaveOthermConnected;
        [DataMemberAttribute(Name = "zwaveOthermConnected")]
        public double ZwaveOthermConnected
        {
            get { return _zwaveOthermConnected; }
            set
            {
                if (_zwaveOthermConnected != value)
                {
                    _zwaveOthermConnected = value;
                    OnPropertyChanged("ZwaveOthermConnected");
                }
            }
        }

        private BurnerInfo _burnerInfo;
        [DataMemberAttribute(Name = "burnerInfo")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BurnerInfo BurnerInfo
        {
            get { return _burnerInfo; }
            set
            {
                if (_burnerInfo != value)
                {
                    _burnerInfo = value;
                    OnPropertyChanged("BurnerInfo");
                }
            }
        }

        private string _otCommError;
        [DataMemberAttribute(Name = "otCommError")]
        public string OtCommError
        {
            get { return _otCommError; }
            set
            {
                if (_otCommError != value)
                {
                    _otCommError = value;
                    OnPropertyChanged("OtCommError");
                }
            }
        }

        private string _i2CError;
        [DataMemberAttribute(Name = "i2CError")]
        public string I2CError
        {
            get { return _i2CError; }
            set
            {
                if (_i2CError != value)
                {
                    _i2CError = value;
                    OnPropertyChanged("I2CError");
                }
            }
        }
    }
}
