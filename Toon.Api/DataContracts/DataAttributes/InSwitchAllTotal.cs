using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "inSwitchAllTotal")]
    public class InSwitchAllTotal : NotifyPropertyChanged
    {
        private double _currentState;
        [DataMemberAttribute(Name = "currentState")]
        public double CurrentState
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

        private double _currentUsage;
        [DataMemberAttribute(Name = "currentUsage")]
        public double CurrentUsage
        {
            get { return _currentUsage; }
            set
            {
                if (_currentUsage != value)
                {
                    _currentUsage = value;
                    OnPropertyChanged("CurrentUsage");
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

        private double _avgUsage;
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
    }
}
