using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "powerUsage")]
    public class PowerUsage : CacheEntity
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

        private string _valueProduced;
        [DataMemberAttribute(Name = "valueProduced")]
        public string ValueProduced
        {
            get { return _valueProduced; }
            set
            {
                if (_valueProduced != value)
                {
                    _valueProduced = value;
                    OnPropertyChanged("ValueProduced");
                }
            }
        }

        private string _dayCostProduced;
        [DataMemberAttribute(Name = "dayCostProduced")]
        public string DayCostProduced
        {
            get { return _dayCostProduced; }
            set
            {
                if (_dayCostProduced != value)
                {
                    _dayCostProduced = value;
                    OnPropertyChanged("DayCostProduced");
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

        private double _avgProduValue;
        [DataMemberAttribute(Name = "avgProduValue")]
        public double AvgProduValue
        {
            get { return _avgProduValue; }
            set
            {
                if (_avgProduValue != value)
                {
                    _avgProduValue = value;
                    OnPropertyChanged("AvgProduValue");
                }
            }
        }

        private double _avgDayProduValue;
        [DataMemberAttribute(Name = "avgDayProduValue")]
        public double AvgDayProduValue
        {
            get { return _avgDayProduValue; }
            set
            {
                if (_avgDayProduValue != value)
                {
                    _avgDayProduValue = value;
                    OnPropertyChanged("AvgDayProduValue");
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

        private double _meterReadingLow;
        [DataMemberAttribute(Name = "meterReadingLow")]
        public double MeterReadingLow
        {
            get { return _meterReadingLow; }
            set
            {
                if (_meterReadingLow != value)
                {
                    _meterReadingLow = value;
                    OnPropertyChanged("MeterReadingLow");
                }
            }
        }

        private double _meterReadingProdu;
        [DataMemberAttribute(Name = "meterReadingProdu")]
        public double MeterReadingProdu
        {
            get { return _meterReadingProdu; }
            set
            {
                if (_meterReadingProdu != value)
                {
                    _meterReadingProdu = value;
                    OnPropertyChanged("MeterReadingProdu");
                }
            }
        }

        private double _meterReadingLowProdu;
        [DataMemberAttribute(Name = "meterReadingLowProdu")]
        public double MeterReadingLowProdu
        {
            get { return _meterReadingLowProdu; }
            set
            {
                if (_meterReadingLowProdu != value)
                {
                    _meterReadingLowProdu = value;
                    OnPropertyChanged("MeterReadingLowProdu");
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

        private double _dayLowUsage;
        [DataMemberAttribute(Name = "dayLowUsage")]
        public double DayLowUsage
        {
            get { return _dayLowUsage; }
            set
            {
                if (_dayLowUsage != value)
                {
                    _dayLowUsage = value;
                    OnPropertyChanged("DayLowUsage");
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
