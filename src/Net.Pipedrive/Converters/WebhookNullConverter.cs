using System;
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
                var safeSerializer = JsonSerializer.Create(new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    CheckAdditionalContent = serializer.CheckAdditionalContent,
                    ConstructorHandling = serializer.ConstructorHandling,
                    Context = serializer.Context,
                    ContractResolver = serializer.ContractResolver,
                    Converters = serializer.Converters,
                    Culture = serializer.Culture,
                    DateFormatHandling = serializer.DateFormatHandling,
                    DateFormatString = serializer.DateFormatString,
                    DateParseHandling = serializer.DateParseHandling,
                    DateTimeZoneHandling = serializer.DateTimeZoneHandling,
                    NullValueHandling = serializer.NullValueHandling,
                    DefaultValueHandling = serializer.DefaultValueHandling,
                    EqualityComparer = serializer.EqualityComparer,
                    FloatFormatHandling = serializer.FloatFormatHandling,
                    Formatting = serializer.Formatting,
                    FloatParseHandling = serializer.FloatParseHandling,
                    MaxDepth = serializer.MaxDepth,
                    MetadataPropertyHandling = serializer.MetadataPropertyHandling,
                    MissingMemberHandling = serializer.MissingMemberHandling,
                    ObjectCreationHandling = serializer.ObjectCreationHandling,
                    PreserveReferencesHandling = serializer.PreserveReferencesHandling,
                    SerializationBinder = serializer.SerializationBinder,
                    StringEscapeHandling = serializer.StringEscapeHandling,
                    TraceWriter = serializer.TraceWriter,
                    TypeNameHandling = serializer.TypeNameHandling,
                    TypeNameAssemblyFormatHandling = serializer.TypeNameAssemblyFormatHandling
                });
                safeSerializer.Serialize(writer, value);
            }
        }
    }
}
