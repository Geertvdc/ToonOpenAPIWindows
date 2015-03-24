using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "gasUsage")]
    public class GasUsage : CacheEntity
    {
        private double _value;
        [DataMemberAttribute(Name = "value")]
        public double Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged("Value");
                }
            }
        }

        private double _avgValue;
        [DataMemberAttribute(Name = "avgValue")]
        public double AvgValue
        {
            get { return _avgValue; }
            set
            {
                if (_avgValue != value)
                {
                    _avgValue = value;
                    OnPropertyChanged("AvgValue");
                }
            }
        }

        private double _meterReading;
        [DataMemberAttribute(Name = "meterReading")]
        public double MeterReading
        {
            get { return _meterReading; }
            set
            {
                if (_meterReading != value)
                {
                    _meterReading = value;
                    OnPropertyChanged("MeterReading");
                }
            }
        }

        private double _avgDayValue;
        [DataMemberAttribute(Name = "avgDayValue")]
        public double AvgDayValue
        {
            get { return _avgDayValue; }
            set
            {
                if (_avgDayValue != value)
                {
                    _avgDayValue = value;
                    OnPropertyChanged("AvgDayValue");
                }
            }
        }

        private double _dayUsage;
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

        private double _isSmart;
        [DataMemberAttribute(Name = "isSmart")]
        public double IsSmart
        {
            get { return _isSmart; }
            set
            {
                if (_isSmart != value)
                {
                    _isSmart = value;
                    OnPropertyChanged("IsSmart");
                }
            }
        }
    }
}
