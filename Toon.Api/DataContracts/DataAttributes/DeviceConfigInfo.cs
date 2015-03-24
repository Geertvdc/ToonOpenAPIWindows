using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "deviceConfigInfo")]
    public class DeviceConfigInfo : NotifyPropertyChanged
    {
        private Device[] _device;
        [DataMemberAttribute(Name = "device")]
        public Device[] Device
        {
            get { return _device; }
            set
            {
                if (_device != value)
                {
                    _device = value;
                    OnPropertyChanged("Device");
                }
            }
        }

        private Device[] _setTime;
        [DataMemberAttribute(Name = "setTime")]
        public Device[] setTime
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
