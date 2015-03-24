using System;
using Toon.Api.Helpers;

namespace Toon.Api.DataContracts
{
    public class CacheEntity : NotifyPropertyChanged
    {
        private DateTime _insertedOn;
        public DateTime InsertedOn
        {
            get { return _insertedOn; }
            set
            {
                if (_insertedOn != value)
                {
                    _insertedOn = value;
                    OnPropertyChanged("InsertedOn");
                }
            }
        }
    }
}
