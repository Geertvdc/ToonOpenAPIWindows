using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "benchmarkInfo")]
    public class BenchmarkInfo : NotifyPropertyChanged
    {
        private double _permission;
        [DataMemberAttribute(Name = "permission")]
        public double Permission
        {
            get { return _permission; }
            set
            {
                if (_permission != value)
                {
                    _permission = value;
                    OnPropertyChanged("Permission");
                }
            }
        }

        private double _wizardDone;
        [DataMemberAttribute(Name = "wizardDone")]
        public double WizardDone
        {
            get { return _wizardDone; }
            set
            {
                if (_wizardDone != value)
                {
                    _wizardDone = value;
                    OnPropertyChanged("WizardDone");
                }
            }
        }

        private double _disableNotifications;
        [DataMemberAttribute(Name = "disableNotifications")]
        public double DisableNotifications
        {
            get { return _disableNotifications; }
            set
            {
                if (_disableNotifications != value)
                {
                    _disableNotifications = value;
                    OnPropertyChanged("DisableNotifications");
                }
            }
        }

        private string _screenName;
        [DataMemberAttribute(Name = "screenName")]
        public string ScreenName
        {
            get { return _screenName; }
            set
            {
                if (_screenName != value)
                {
                    _screenName = value;
                    OnPropertyChanged("ScreenName");
                }
            }
        }

        private bool _gotSJV;
        [DataMemberAttribute(Name = "gotSJV")]
        public bool GotSJV
        {
            get { return _gotSJV; }
            set
            {
                if (_gotSJV != value)
                {
                    _gotSJV = value;
                    OnPropertyChanged("GotSJV");
                }
            }
        }

        private double _homeType;
        [DataMemberAttribute(Name = "homeType")]
        public double HomeType
        {
            get { return _homeType; }
            set
            {
                if (_homeType != value)
                {
                    _homeType = value;
                    OnPropertyChanged("HomeType");
                }
            }
        }

        private double _homeTypeAlt;
        [DataMemberAttribute(Name = "homeTypeAlt")]
        public double HomeTypeAlt
        {
            get { return _homeTypeAlt; }
            set
            {
                if (_homeTypeAlt != value)
                {
                    _homeTypeAlt = value;
                    OnPropertyChanged("HomeTypeAlt");
                }
            }
        }

        private double _homeBuildPeriod;
        [DataMemberAttribute(Name = "homeBuildPeriod")]
        public double HomeBuildPeriod
        {
            get { return _homeBuildPeriod; }
            set
            {
                if (_homeBuildPeriod != value)
                {
                    _homeBuildPeriod = value;
                    OnPropertyChanged("HomeBuildPeriod");
                }
            }
        }

        private double _homeSize;
        [DataMemberAttribute(Name = "homeSize")]
        public double HomeSize
        {
            get { return _homeSize; }
            set
            {
                if (_homeSize != value)
                {
                    _homeSize = value;
                    OnPropertyChanged("HomeSize");
                }
            }
        }

        private double _familyType;
        [DataMemberAttribute(Name = "familyType")]
        public double FamilyType
        {
            get { return _familyType; }
            set
            {
                if (_familyType != value)
                {
                    _familyType = value;
                    OnPropertyChanged("FamilyType");
                }
            }
        }

        private double _setTime;
        [DataMemberAttribute(Name = "setTime")]
        public double SetTime
        {
            get { return _setTime; }
            set
            {
                if (_setTime != value)
                {
                    _setTime = value;
                    OnPropertyChanged("SetTime");
                }
            }
        }
    }
}
