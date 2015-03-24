using System;
using System.Runtime.Serialization;
using Toon.Api.DataContracts.DataAttributes;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts
{
    [DataContractAttribute()]
    public class ToonStateResponse : NotifyPropertyChanged
    {
        private bool _success;
        /// <summary>
        /// Defines wheter the respons
        /// </summary>
        [DataMemberAttribute(Name = "success")]
        public bool Success
        {
            get { return _success; }
            set
            {
                if (_success != value)
                {
                    _success = value;
                    OnPropertyChanged("Success");
                }
            }
        }


        private string _reason;
        [DataMemberAttribute(Name = "reason")]
        public string Reason
        {
            get { return _reason; }
            set
            {
                if (_reason != value)
                {
                    _reason = value;
                    OnPropertyChanged("Reason");
                }
            }
        }

        private string _errorCode;
        /// <summary>
        /// "communicationError" / "mobileAccessNotAllowed" / "unknown"
        /// </summary>
        [DataMemberAttribute(Name = "errorCode")]
        public string ErrorCode
        {
            get { return _errorCode; }
            set
            {
                if (_errorCode != value)
                {
                    _errorCode = value;
                    OnPropertyChanged("ErrorCode");
                }
            }
        }

        private ThermostatInfo _thermostatInfo;
        /// <summary>
        /// If only thermostat information has been updated
        /// </summary>
        [DataMemberAttribute(Name = "thermostatInfo")]
        public ThermostatInfo ThermostatInfo
        {
            get { return _thermostatInfo; }
            set
            {
                if (_thermostatInfo != value)
                {
                    _thermostatInfo = value;
                    OnPropertyChanged("ThermostatInfo");
                }
            }
        }

        private GasUsage _gasUsage;
        /// <summary>
        /// If gas, district heat and/or power usage have been updated
        /// </summary>
        [DataMemberAttribute(Name = "gasUsage")]
        public GasUsage GasUsage
        {
            get { return _gasUsage; }
            set
            {
                if (_gasUsage != value)
                {
                    _gasUsage = value;
                    OnPropertyChanged("GasUsage");
                }
            }
        }

        private HeatUsage _heatUsage;
        /// <summary>
        /// If gas, district heat and/or power usage have been updated
        /// </summary>
        [DataMemberAttribute(Name = "heatUsage")]
        public HeatUsage HeatUsage
        {
            get { return _heatUsage; }
            set
            {
                if (_heatUsage != value)
                {
                    _heatUsage = value;
                    OnPropertyChanged("HeatUsage");
                }
            }
        }

        private PowerUsage _powerUsage;
        /// <summary>
        /// If gas, district heat and/or power usage have been updated
        /// </summary>
        [DataMemberAttribute(Name = "powerUsage")]
        public PowerUsage PowerUsage
        {
            get { return _powerUsage; }
            set
            {
                if (_powerUsage != value)
                {
                    _powerUsage = value;
                    OnPropertyChanged("PowerUsage");
                }
            }
        }

        private int _toTime;
        [DataMemberAttribute(Name = "toTime")]
        public int ToTime
        {
            get { return _toTime; }
            set
            {
                if (_toTime != value)
                {
                    _toTime = value;
                    OnPropertyChanged("ToTime");
                    OnPropertyChanged("ToReadableTime");
                }
            }
        }

        [IgnoreDataMember]
        DateTime ToReadableTime
        {
            get { return Helpers.DateTimeConverter.FromUnixTime(ToTime); }
        }

        private GraphData _graphData;
        [DataMemberAttribute(Name = "graphData")]
        public GraphData GraphData
        {
            get { return _graphData; }
            set
            {
                if (_graphData != value)
                {
                    _graphData = value;
                    OnPropertyChanged("GraphData");
                }
            }
        }

        private ThermostatProgram _thermostatProgram;
        [DataMemberAttribute(Name = "thermostatProgram")]
        public ThermostatProgram ThermostatProgram
        {
            get { return _thermostatProgram; }
            set
            {
                if (_thermostatProgram != value)
                {
                    _thermostatProgram = value;
                    OnPropertyChanged("ThermostatProgram");
                }
            }
        }

        private ThermostatStates _thermostatStates;
        [DataMemberAttribute(Name = "thermostatStates")]
        public ThermostatStates ThermostatStates
        {
            get { return _thermostatStates; }
            set
            {
                if (_thermostatStates != value)
                {
                    _thermostatStates = value;
                    OnPropertyChanged("ThermostatStates");
                }
            }
        }

        private MonthData _monthData;
        /// <summary>
        /// If only month data (with estimated usage data) has been updated
        /// </summary>
        [DataMemberAttribute(Name = "monthData")]
        public MonthData MonthData
        {
            get { return _monthData; }
            set
            {
                if (_monthData != value)
                {
                    _monthData = value;
                    OnPropertyChanged("MonthData");
                }
            }
        }

        private BillingInfo _billingInfo;
        /// <summary>
        /// If only billing information has been updated
        /// </summary>
        [DataMemberAttribute(Name = "billingInfo")]
        public BillingInfo BillingInfo
        {
            get { return _billingInfo; }
            set
            {
                if (_billingInfo != value)
                {
                    _billingInfo = value;
                    OnPropertyChanged("BillingInfo");
                }
            }
        }

        private BenchmarkData _benchmarkData;
        /// <summary>
        /// If only the benchmark data has been updated
        /// </summary>
        [DataMemberAttribute(Name = "benchmarkData")]
        public BenchmarkData BenchmarkData
        {
            get { return _benchmarkData; }
            set
            {
                if (_benchmarkData != value)
                {
                    _benchmarkData = value;
                    OnPropertyChanged("BenchmarkData");
                }
            }
        }

        private BenchmarkFriends _benchmarkFriends;
        /// <summary>
        /// If only benchmark friends has been updated
        /// </summary>
        [DataMemberAttribute(Name = "benchmarkFriends")]
        public BenchmarkFriends BenchmarkFriends
        {
            get { return _benchmarkFriends; }
            set
            {
                if (_benchmarkFriends != value)
                {
                    _benchmarkFriends = value;
                    OnPropertyChanged("BenchmarkFriends");
                }
            }
        }

        private BenchmarkInfo _benchmarkInfo;
        /// <summary>
        /// If only benchmark information has been updated
        /// </summary>
        [DataMemberAttribute(Name = "benchmarkInfo")]
        public BenchmarkInfo BenchmarkInfo
        {
            get { return _benchmarkInfo; }
            set
            {
                if (_benchmarkInfo != value)
                {
                    _benchmarkInfo = value;
                    OnPropertyChanged("BenchmarkInfo");
                }
            }
        }

        private DeviceConfigInfo _deviceConfigInfo;
        /// <summary>
        /// If only device config information has been updated
        /// </summary>
        [DataMemberAttribute(Name = "deviceConfigInfo")]
        public DeviceConfigInfo DeviceConfigInfo
        {
            get { return _deviceConfigInfo; }
            set
            {
                if (_deviceConfigInfo != value)
                {
                    _deviceConfigInfo = value;
                    OnPropertyChanged("DeviceConfigInfo");
                }
            }
        }

        private DeviceStatusInfo _deviceStatusInfo;
        /// <summary>
        /// If only device status information has been updated
        /// </summary>
        [DataMemberAttribute(Name = "deviceStatusInfo")]
        public DeviceStatusInfo DeviceStatusInfo
        {
            get { return _deviceStatusInfo; }
            set
            {
                if (_deviceStatusInfo != value)
                {
                    _deviceStatusInfo = value;
                    OnPropertyChanged("DeviceStatusInfo");
                }
            }
        }

        private DisplayCommError _displayCommError;
        [DataMemberAttribute(Name = "displayCommError")]
        public DisplayCommError DisplayCommError
        {
            get { return _displayCommError; }
            set
            {
                if (_displayCommError != value)
                {
                    _displayCommError = value;
                    OnPropertyChanged("ErrorCode");
                }
            }
        }
    }
}
