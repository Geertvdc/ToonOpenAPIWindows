using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "billingInfo")]
    public class BillingInfo : NotifyPropertyChanged
    {
        private Info[] _info;
        [DataMemberAttribute(Name = "info")]
        public Info[] Info
        {
            get { return _info; }
            set
            {
                if (_info != value)
                {
                    _info = value;
                    OnPropertyChanged("HomeTypeAlt");
                }
            }
        }
    }
}
