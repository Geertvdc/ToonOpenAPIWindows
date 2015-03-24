using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "deviceStatusInfo")]
    public class DeviceStatusInfo : NotifyPropertyChanged
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

        private InSwitchAllTotal _inSwitchAllTotal;
        [DataMemberAttribute(Name = "inSwitchAllTotal")]
        public InSwitchAllTotal InSwitchAllTotal
        {
            get { return _inSwitchAllTotal; }
            set
            {
                if (_inSwitchAllTotal != value)
                {
                    _inSwitchAllTotal = value;
                    OnPropertyChanged("InSwitchAllTotal");
                }
            }
        }
    }
}
