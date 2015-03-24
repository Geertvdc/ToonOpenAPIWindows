using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "info")]
    public class Info : NotifyPropertyChanged
    {
        private string _type;
        [DataMemberAttribute(Name = "type")]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChanged("Type");
                }
            }
        }

        private double _lastBillStart;
        [DataMemberAttribute(Name = "lastBillStart")]
        public double LastBillStart
        {
            get { return _lastBillStart; }
            set
            {
                if (_lastBillStart != value)
                {
                    _lastBillStart = value;
                    OnPropertyChanged("LastBillStart");
                }
            }
        }

        private double _lastBillEnd;
        [DataMemberAttribute(Name = "lastBillEnd")]
        public double LastBillEnd
        {
            get { return _lastBillEnd; }
            set
            {
                if (_lastBillEnd != value)
                {
                    _lastBillEnd = value;
                    OnPropertyChanged("LastBillEnd");
                }
            }
        }

        private double _lastBillRate;
        [DataMemberAttribute(Name = "lastBillRate")]
        public double LastBillRate
        {
            get { return _lastBillRate; }
            set
            {
                if (_lastBillRate != value)
                {
                    _lastBillRate = value;
                    OnPropertyChanged("LastBillRate");
                }
            }
        }

        private double _lastBillUsage;
        [DataMemberAttribute(Name = "lastBillUsage")]
        public double LastBillUsage
        {
            get { return _lastBillUsage; }
            set
            {
                if (_lastBillUsage != value)
                {
                    _lastBillUsage = value;
                    OnPropertyChanged("LastBillUsage");
                }
            }
        }

        private double _lastBillLowUsage;
        [DataMemberAttribute(Name = "lastBillLowUsage")]
        public double LastBillLowUsage
        {
            get { return _lastBillLowUsage; }
            set
            {
                if (_lastBillLowUsage != value)
                {
                    _lastBillLowUsage = value;
                    OnPropertyChanged("LastBillLowUsage");
                }
            }
        }

        private double _rate;
        [DataMemberAttribute(Name = "rate")]
        public double Rate
        {
            get { return _rate; }
            set
            {
                if (_rate != value)
                {
                    _rate = value;
                    OnPropertyChanged("Rate");
                }
            }
        }

        private double _telmiEnabled;
        [DataMemberAttribute(Name = "telmiEnabled")]
        public double TelmiEnabled
        {
            get { return _telmiEnabled; }
            set
            {
                if (_telmiEnabled != value)
                {
                    _telmiEnabled = value;
                    OnPropertyChanged("TelmiEnabled");
                }
            }
        }

        private double _usage;
        [DataMemberAttribute(Name = "usage")]
        public double Usage
        {
            get { return _usage; }
            set
            {
                if (_usage != value)
                {
                    _usage = value;
                    OnPropertyChanged("Usage");
                }
            }
        }

        private double _lowUsage;
        [DataMemberAttribute(Name = "lowUsage")]
        public double LowUsage
        {
            get { return _lowUsage; }
            set
            {
                if (_lowUsage != value)
                {
                    _lowUsage = value;
                    OnPropertyChanged("LowUsage");
                }
            }
        }

        private double _price;
        [DataMemberAttribute(Name = "price")]
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged("_price");
                }
            }
        }

        private double _lowPrice;
        [DataMemberAttribute(Name = "lowPrice")]
        public double LowPrice
        {
            get { return _lowPrice; }
            set
            {
                if (_lowPrice != value)
                {
                    _lowPrice = value;
                    OnPropertyChanged("LowPrice");
                }
            }
        }

        private double _nextBillingDate;
        [DataMemberAttribute(Name = "nextBillingDate")]
        public double NextBillingDate
        {
            get { return _nextBillingDate; }
            set
            {
                if (_nextBillingDate != value)
                {
                    _nextBillingDate = value;
                    OnPropertyChanged("NextBillingDate");
                }
            }
        }

        private double _changeDate;
        /// <summary>
        /// In case of type elec or gas
        /// </summary>
        [DataMemberAttribute(Name = "changeDate")]
        public double ChangeDate
        {
            get { return _changeDate; }
            set
            {
                if (_changeDate != value)
                {
                    _changeDate = value;
                    OnPropertyChanged("ChangeDate");
                }
            }
        }

        private double _installedDate;
        /// <summary>
        /// In case of type elec_produ
        /// </summary>
        [DataMemberAttribute(Name = "installedDate")]
        public double InstalledDate
        {
            get { return _installedDate; }
            set
            {
                if (_installedDate != value)
                {
                    _installedDate = value;
                    OnPropertyChanged("InstalledDate");
                }
            }
        }
    }
}
