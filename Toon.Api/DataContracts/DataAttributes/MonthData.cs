using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "monthData")]
    public class MonthData : NotifyPropertyChanged
    {
        private Month[] _month;
        [DataMemberAttribute(Name = "month")]
        public Month[] Month
        {
            get { return _month; }
            set
            {
                if (_month != value)
                {
                    _month = value;
                    OnPropertyChanged("Month");
                }
            }
        }
    }
}
