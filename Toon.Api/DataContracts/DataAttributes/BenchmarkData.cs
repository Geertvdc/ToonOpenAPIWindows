using System.Runtime.Serialization;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts.DataAttributes
{
    [DataContractAttribute(Name = "benchmarkData")]
    public class BenchmarkData : NotifyPropertyChanged
    {
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
    }
}
