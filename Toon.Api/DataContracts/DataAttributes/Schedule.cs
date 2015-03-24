using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "schedules")]
    public class Schedule : NotifyPropertyChanged
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

        private int _startDayOfWeek;
        [DataMemberAttribute(Name = "startDayOfWeek")]
        public int StartDayOfWeek
        {
            get { return _startDayOfWeek; }
            set
            {
                if (_startDayOfWeek != value)
                {
                    _startDayOfWeek = value;
                    OnPropertyChanged("StartDayOfWeek");
                }
            }
        }

        private int _startHour;
        [DataMemberAttribute(Name = "startHour")]
        public int StartHour
        {
            get { return _startHour; }
            set
            {
                if (_startHour != value)
                {
                    _startHour = value;
                    OnPropertyChanged("StartHour");
                }
            }
        }

        private int _startMin;
        [DataMemberAttribute(Name = "startMin")]
        public int StartMin
        {
            get { return _startMin; }
            set
            {
                if (_startMin != value)
                {
                    _startMin = value;
                    OnPropertyChanged("StartMin");
                }
            }
        }

        private int _endDayOfWeek;
        [DataMemberAttribute(Name = "endDayOfWeek")]
        public int EndDayOfWeek
        {
            get { return _endDayOfWeek; }
            set
            {
                if (_endDayOfWeek != value)
                {
                    _endDayOfWeek = value;
                    OnPropertyChanged("EndDayOfWeek");
                }
            }
        }

        private int _endHour;
        [DataMemberAttribute(Name = "endHour")]
        public int EndHour
        {
            get { return _endHour; }
            set
            {
                if (_endHour != value)
                {
                    _endHour = value;
                    OnPropertyChanged("EndHour");
                }
            }
        }

        private int _endMin;
        [DataMemberAttribute(Name = "endMin")]
        public int EndMin
        {
            get { return _endMin; }
            set
            {
                if (_endMin != value)
                {
                    _endMin = value;
                    OnPropertyChanged("EndMin");
                }
            }
        }

        private int _targetState;
        [DataMemberAttribute(Name = "targetState")]
        public int TargetState
        {
            get { return _targetState; }
            set
            {
                if (_targetState != value)
                {
                    _targetState = value;
                    OnPropertyChanged("TargetState");
                }
            }
        }
    }
}
