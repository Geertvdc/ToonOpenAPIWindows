using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "month")]
    public class Month : NotifyPropertyChanged
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

        private double _year;
        [DataMemberAttribute(Name = "year")]
        public double Year
        {
            get { return _year; }
            set
            {
                if (_year != value)
                {
                    _year = value;
                    OnPropertyChanged("Year");
                }
            }
        }

        private double _month;
        [DataMemberAttribute(Name = "month")]
        public double MonthOfYear
        {
            get { return _month; }
            set
            {
                if (_month != value)
                {
                    _month = value;
                    OnPropertyChanged("MonthOfYear");
                }
            }
        }

        private double _startDay;
        [DataMemberAttribute(Name = "startDay")]
        public double StartDay
        {
            get { return _startDay; }
            set
            {
                if (_startDay != value)
                {
                    _startDay = value;
                    OnPropertyChanged("StartDay");
                }
            }
        }

        private double _targetUsage;
        /// <summary>
        /// estimated usage
        /// </summary>
        [DataMemberAttribute(Name = "targetUsage")]
        public double TargetUsage
        {
            get { return _targetUsage; }
            set
            {
                if (_targetUsage != value)
                {
                    _targetUsage = value;
                    OnPropertyChanged("TargetUsage");
                }
            }
        }

        private double _targetLowUsage;
        /// <summary>
        /// estimated low usage
        /// </summary>
        [DataMemberAttribute(Name = "targetLowUsage")]
        public double TargetLowUsage
        {
            get { return _targetLowUsage; }
            set
            {
                if (_targetLowUsage != value)
                {
                    _targetLowUsage = value;
                    OnPropertyChanged("TargetLowUsage");
                }
            }
        }

        private double _visitedMonth;
        [DataMemberAttribute(Name = "visitedMonth")]
        public double VisitedMonth
        {
            get { return _visitedMonth; }
            set
            {
                if (_visitedMonth != value)
                {
                    _visitedMonth = value;
                    OnPropertyChanged("VisitedMonth");
                }
            }
        }

        private double _realUsage;

        [DataMemberAttribute(Name = "realUsage")]
        public double RealUsage
        {
            get { return _realUsage; }
            set
            {
                if (_realUsage != value)
                {
                    _realUsage = value;
                    OnPropertyChanged("RealUsage");
                }
            }
        }

        private double _realLowUsage;
        [DataMemberAttribute(Name = "realLowUsage")]
        public double RealLowUsage
        {
            get { return _realLowUsage; }
            set
            {
                if (_realLowUsage != value)
                {
                    _realLowUsage = value;
                    OnPropertyChanged("RealLowUsage");
                }
            }
        }

        private double _targetCost;
        /// <summary>
        /// estimated cost
        /// </summary>
        [DataMemberAttribute(Name = "targetCost")]
        public double TargetCost
        {
            get { return _targetCost; }
            set
            {
                if (_targetCost != value)
                {
                    _targetCost = value;
                    OnPropertyChanged("TargetCost");
                }
            }
        }

        private double _targetLowCost;
        /// <summary>
        /// estimated low cost
        /// </summary>
        [DataMemberAttribute(Name = "targetLowCost")]
        public double TargetLowCost
        {
            get { return _targetLowCost; }
            set
            {
                if (_targetLowCost != value)
                {
                    _targetLowCost = value;
                    OnPropertyChanged("TargetLowCost");
                }
            }
        }

        private double _realCost;
        [DataMemberAttribute(Name = "realCost")]
        public double RealCost
        {
            get { return _realCost; }
            set
            {
                if (_realCost != value)
                {
                    _realCost = value;
                    OnPropertyChanged("RealCost");
                }
            }
        }

        private double _realLowCost;
        [DataMemberAttribute(Name = "realLowCost")]
        public double RealLowCost
        {
            get { return _realLowCost; }
            set
            {
                if (_realLowCost != value)
                {
                    _realLowCost = value;
                    OnPropertyChanged("RealLowCost");
                }
            }
        }
    }
}
