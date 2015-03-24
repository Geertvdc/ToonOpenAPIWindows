using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "friend")]
    public class Friend : NotifyPropertyChanged
    {
        private string _commonname;
        [DataMemberAttribute(Name = "commonname")]
        public string CommonName
        {
            get { return _commonname; }
            set
            {
                if (_commonname != value)
                {
                    _commonname = value;
                    OnPropertyChanged("CommonName");
                }
            }
        }

        private string _hash;
        [DataMemberAttribute(Name = "hash")]
        public string Hash
        {
            get { return _hash; }
            set
            {
                if (_hash != value)
                {
                    _hash = value;
                    OnPropertyChanged("Hash");
                }
            }
        }

        private string _name;
        [DataMemberAttribute(Name = "name")]
        public string Name
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

        private string _zipcode;
        [DataMemberAttribute(Name = "zipcode")]
        public string Zipcode
        {
            get { return _zipcode; }
            set
            {
                if (_zipcode != value)
                {
                    _zipcode = value;
                    OnPropertyChanged("Zipcode");
                }
            }
        }

        private double _requestT;
        [DataMemberAttribute(Name = "requestT")]
        public double RequestT
        {
            get { return _requestT; }
            set
            {
                if (_requestT != value)
                {
                    _requestT = value;
                    OnPropertyChanged("RequestT");
                }
            }
        }

        private double _accepted;
        [DataMemberAttribute(Name = "accepted")]
        public double Accepted
        {
            get { return _accepted; }
            set
            {
                if (_accepted != value)
                {
                    _accepted = value;
                    OnPropertyChanged("Accepted");
                }
            }
        }

        private double _friendState;
        [DataMemberAttribute(Name = "friendState")]
        public double FriendState
        {
            get { return _friendState; }
            set
            {
                if (_friendState != value)
                {
                    _friendState = value;
                    OnPropertyChanged("FriendState");
                }
            }
        }

        private double _compareActive;
        [DataMemberAttribute(Name = "compareActive")]
        public double CompareActive
        {
            get { return _compareActive; }
            set
            {
                if (_compareActive != value)
                {
                    _compareActive = value;
                    OnPropertyChanged("CompareActive");
                }
            }
        }

        private DataValues[] _dataValues;
        [DataMemberAttribute(Name = "dataValues")]
        public DataValues[] DataValues
        {
            get { return _dataValues; }
            set
            {
                if (_dataValues != value)
                {
                    _dataValues = value;
                    OnPropertyChanged("DataValues");
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
