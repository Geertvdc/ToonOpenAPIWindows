using System.Runtime.Serialization;

namespace Toon.Api.Enums
{
    public enum BurnerInfo
    {
        [EnumMember(Value = "0")]
        Cooling,
        [EnumMember(Value = "1")]
        Heating
    }
}
