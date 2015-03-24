using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "displayCommError")]
    public class DisplayCommError : NotifyPropertyChanged
    {
        private string _message;
        [DataMemberAttribute(Name = "message")]
        public string Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged("Message");
                }
            }
        }
    }
}
