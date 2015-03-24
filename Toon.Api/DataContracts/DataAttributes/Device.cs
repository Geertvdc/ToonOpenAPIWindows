using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "device")]
    public class Device : NotifyPropertyChanged
    {
        private string _devUUID;
        [DataMemberAttribute(Name = "DevUUID")]
        public string DeviceUUID
        {
            get { return _devUUID; }
            set
            {
                if (_devUUID != value)
                {
                    _devUUID = value;
                    OnPropertyChanged("DeviceUUID");
                }
            }
        }

        private string _zWUuid;
        [DataMemberAttribute(Name = "ZWUuid")]// Todo: Figure out what this is
        public string ZWUuid
        {
            get { return _zWUuid; }
            set
            {
                if (_zWUuid != value)
                {
                    _zWUuid = value;
                    OnPropertyChanged("ZWUuid");
                }
            }
        }

        [IgnoreDataMember]
        public string FlowGraphUuidFilled
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(FlowGraphUuid))
                    return FlowGraphUuid;
                else
                {
                    string format = "plug_elec_flow_";
                    string[] split = ZWUuid.Split('_');
                    string getLast = split[split.Length - 1];
                    return format + getLast;
                }
            }
        }

        [IgnoreDataMember]
        public string QuantityGraphUuidFilled
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(QuantityGraphUuid))
                    return QuantityGraphUuid;

                else
                {
                    string format = "plug_elec_qtty_";
                    string[] split = ZWUuid.Split('_');
                    string getLast = split[split.Length - 1];
                    return format + getLast;
                }
            }
        }

        private string _devType;
        [DataMemberAttribute(Name = "DevType")]
        public string DeviceType
        {
            get { return _devType; }
            set
            {
                if (_devType != value)
                {
                    _devType = value;
                    OnPropertyChanged("DevType");
                }
            }
        }

        private string _name;
        [DataMemberAttribute(Name = "Name")]
        public string DeviceName
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private string _flowGraphUuid;
        [DataMemberAttribute(Name = "FlowGraphUuid")]
        public string FlowGraphUuid
        {
            get { return _flowGraphUuid; }
            set
            {
                if (_flowGraphUuid != value)
                {
                    _flowGraphUuid = value;
                    OnPropertyChanged("FlowGraphUuid");
                }
            }
        }

        private string _quantityGraphUuid;
        [DataMemberAttribute(Name = "QuantityGraphUuid")]
        public string QuantityGraphUuid
        {
            get { return _quantityGraphUuid; }
            set
            {
                if (_quantityGraphUuid != value)
                {
                    _quantityGraphUuid = value;
                    OnPropertyChanged("QuantityGraphUuid");
                }
            }
        }

        private string _position;
        [DataMemberAttribute(Name = "Position")]
        public string Position
        {
            get { return _position; }
            set
            {
                if (_position != value)
                {
                    _position = value;
                    OnPropertyChanged("Position");
                }
            }
        }

        private string _inSwitchAll;
        [DataMemberAttribute(Name = "InSwitchAll")]
        public string InSwitchAll
        {
            get { return _inSwitchAll; }
            set
            {
                if (_inSwitchAll != value)
                {
                    _inSwitchAll = value;
                    OnPropertyChanged("InSwitchAll");
                }
            }
        }

        private string _inSwitchSchedule;
        [DataMemberAttribute(Name = "InSwitchSchedule")]
        public string InSwitchSchedule
        {
            get { return _inSwitchSchedule; }
            set
            {
                if (_inSwitchSchedule != value)
                {
                    _inSwitchSchedule = value;
                    OnPropertyChanged("InSwitchSchedule");
                }
            }
        }

        private string _rgbColor;
        /// <summary>
        /// Only used for HUE lamp
        /// </summary>
        [DataMemberAttribute(Name = "RgbColor")]
        public string RgbColor
        {
            get { return _rgbColor; }
            set
            {
                if (_rgbColor != value)
                {
                    _rgbColor = value;
                    OnPropertyChanged("RgbColor");
                }
            }
        }

        private string _usageCapable;
        /// <summary>
        /// Only used for Smart Plug
        /// </summary>
        [DataMemberAttribute(Name = "UsageCapable")]
        public string UsageCapable
        {
            get { return _usageCapable; }
            set
            {
                if (_usageCapable != value)
                {
                    _usageCapable = value;
                    OnPropertyChanged("UsageCapable");
                }
            }
        }

        private string _currentState;
        [DataMemberAttribute(Name = "CurrentState")]
        public string CurrentState
        {
            get { return _currentState; }
            set
            {
                if (_currentState != value)
                {
                    _currentState = value;
                    OnPropertyChanged("CurrentState");
                }
            }
        }

        private double _dayUsage;
        /// <summary>
        /// This attribute will be available only for smartplugs
        /// </summary>
        [DataMemberAttribute(Name = "dayUsage")]
        public double DayUsage
        {
            get { return _dayUsage; }
            set
            {
                if (_dayUsage != value)
                {
                    _dayUsage = value;
                    OnPropertyChanged("DayUsage");
                }
            }
        }

        private double _avgUsage;
        /// <summary>
        /// This attribute will be available only for smartplugs
        /// </summary>
        [DataMemberAttribute(Name = "avgUsage")]
        public double AvgUsage
        {
            get { return _avgUsage; }
            set
            {
                if (_avgUsage != value)
                {
                    _avgUsage = value;
                    OnPropertyChanged("AvgUsage");
                }
            }
        }

        private double _isConnected;
        [DataMemberAttribute(Name = "isConnected")]
        public double IsConnected
        {
            get { return _isConnected; }
            set
            {
                if (_isConnected != value)
                {
                    _isConnected = value;
                    OnPropertyChanged("IsConnected");
                }
            }
        }

        private double _networkHealthState;
        [DataMemberAttribute(Name = "networkHealthState")]
        public double NetworkHealthState
        {
            get { return _networkHealthState; }
            set
            {
                if (_networkHealthState != value)
                {
                    _networkHealthState = value;
                    OnPropertyChanged("NetworkHealthState");
                }
            }
        }
    }
}
