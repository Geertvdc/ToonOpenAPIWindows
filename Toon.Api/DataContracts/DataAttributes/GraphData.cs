using System.Collections.Generic;
using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "graphData")]
    public class GraphData : NotifyPropertyChanged
    {
        private Dictionary<long, string> _hours;
        [DataMemberAttribute(Name = "hours")]
        public Dictionary<long, string> Hours
        {
            get { return _hours; }
            set
            {
                if (_hours != value)
                {
                    _hours = value;
                    OnPropertyChanged("Hours");
                }
            }
        }
    }
}
