using Newtonsoft.Json;
using System;
using Toon.Api.Enums;

namespace Toon.Api.Helpers
{
    public class ThermostatStateEnumConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            ThermostatState thermostatState = (ThermostatState)value;
            writer.WriteValue((int)thermostatState);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // We first need to unbox the value to it's original type before we can cast it to int
            var enumValue = (int)(Int64)reader.Value;

            if (Enum.IsDefined(typeof(ThermostatState), enumValue))
            {
                return (ThermostatState)enumValue;
            }
            else
            {
                return ThermostatState.Undefined;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
