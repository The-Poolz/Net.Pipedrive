using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Net.Pipedrive.Converters
{
    public class WebhookNullConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            return token.Type == JTokenType.Null ? null : token.ToObject(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                var properties = value.GetType().GetProperties().Where(p => p.CanRead);

                writer.WriteStartObject();

                foreach (var property in properties)
                {
                    var propertyValue = property.GetValue(value);
                    var propertyType = property.PropertyType;

                    writer.WritePropertyName(property.Name);
                    serializer.Serialize(writer, propertyValue, propertyType);
                }

                writer.WriteEndObject();
            }
        }
    }
}
