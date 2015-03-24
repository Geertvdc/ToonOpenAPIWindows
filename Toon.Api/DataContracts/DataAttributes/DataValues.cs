using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "dataValues")]
    public class DataValues : NotifyPropertyChanged
    {
        private string _usageType;
        [DataMemberAttribute(Name = "usageType")]
        public string UsageType
        {
            get { return _usageType; }
            set
            {
                if (_usageType != value)
                {
                    _usageType = value;
                    OnPropertyChanged("UsageType");
                }
            }
        }

        private string _period;
        [DataMemberAttribute(Name = "period")]
        public string Period
        {
            get { return _period; }
            set
            {
                if (_period != value)
                {
                    _period = value;
                    OnPropertyChanged("Period");
                }
            }
        }

        private double _lastSampleT;
        [DataMemberAttribute(Name = "lastSampleT")]
        public double LastSampleT
        {
            get { return _lastSampleT; }
            set
            {
                if (_lastSampleT != value)
                {
                    _lastSampleT = value;
                    OnPropertyChanged("LastSampleT");
                }
            }
        }

        private string _percentiles;
        [DataMemberAttribute(Name = "percentiles")]
        public string Percentiles
        {
            get { return _percentiles; }
            set
            {
                if (_percentiles != value)
                {
                    _percentiles = value;
                    OnPropertyChanged("Percentiles");
                }
            }
        }

        private string _avgUsages;
        [DataMemberAttribute(Name = "avgUsages")]
        public string AvgUsages
        {
            get { return _avgUsages; }
            set
            {
                if (_avgUsages != value)
                {
                    _avgUsages = value;
                    OnPropertyChanged("AvgUsages");
                }
            }
        }

        private string _usages;
        [DataMemberAttribute(Name = "usages")]
        public string Usages
        {
            get { return _usages; }
            set
            {
                if (_usages != value)
                {
                    _usages = value;
                    OnPropertyChanged("Usages");
                }
            }
        }

        private string _lowUsages;
        [DataMemberAttribute(Name = "lowUsages")]
        public string LowUsages
        {
            get { return _lowUsages; }
            set
            {
                if (_lowUsages != value)
                {
                    _lowUsages = value;
                    OnPropertyChanged("LowUsages");
                }
            }
        }

        private string _compareToCount;
        [DataMemberAttribute(Name = "compareToCount")]
        public string CompareToCount
        {
            get { return _compareToCount; }
            set
            {
                if (_compareToCount != value)
                {
                    _compareToCount = value;
                    OnPropertyChanged("CompareToCount");
                }
            }
        }
    }
}
