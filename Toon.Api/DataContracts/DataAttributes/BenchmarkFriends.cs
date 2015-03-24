using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "benchmarkFriends")]
    public class BenchmarkFriends : NotifyPropertyChanged
    {
        private Friend[] _friend;
        [DataMemberAttribute(Name = "friend")]
        public Friend[] Friend
        {
            get { return _friend; }
            set
            {
                if (_friend != value)
                {
                    _friend = value;
                    OnPropertyChanged("Friend");
                }
            }
        }
    }
}
