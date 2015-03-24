using Newtonsoft.Json;
using System;
using Toon.Api.Enums;

namespace Toon.Api.Helpers
{
    public class ProgramStateEnumConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            ProgramState programState = (ProgramState)value;
            writer.WriteValue((int)programState);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // We first need to unbox the value to it's original type before we can cast it to int
            var enumValue = (int)(Int64)reader.Value;

            if (Enum.IsDefined(typeof(ProgramState), enumValue))
            {
                return (ProgramState)enumValue;
            }
            else
            {
                return ProgramState.Undefined;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
