using Xunit;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Net.Pipedrive.Webhooks;
using Net.Pipedrive.Converters;

namespace Net.Pipedrive.Tests.Converters
{
    public class WebhookNullConverterTests
    {
        public class TheCanConvertMethod
        {
            [Fact]
            public void ReturnsTrueForAnyType()
            {
                var converter = new WebhookNullConverter();
                var result = converter.CanConvert(typeof(string));
                Assert.True(result);
            }
        }

        public class TheReadJsonMethod
        {
            [Fact]
            public void DeserializesObjectCorrectly()
            {
                const string json = "{ \"v\": 1, \"current\": null, \"previous\": null }";
                var result = JsonConvert.DeserializeObject<WebhookResponse<WebhookOrganization>>(json);

                Assert.NotNull(result);
                Assert.Equal(1, result.V);
                Assert.Null(result.Current);
                Assert.Null(result.Previous);
            }

            [Fact]
            public void DeserializesNonExistingPropertiesAsNull()
            {
                const string json = "{ \"v\": 1 }";
                var result = JsonConvert.DeserializeObject<WebhookResponse<WebhookOrganization>>(json);

                Assert.NotNull(result);
                Assert.Equal(1, result.V);
                Assert.Null(result.Current);
                Assert.Null(result.Previous);
            }

            [Fact]
            public void ReturnsNullWhenTokenIsNull()
            {
                var converter = new WebhookNullConverter();
                using var reader = new JsonTextReader(new StringReader("null"));
                var result = converter.ReadJson(reader, typeof(string), null, JsonSerializer.CreateDefault());
                Assert.Null(result);
            }

            [Fact]
            public void DeserializesWhenTokenIsNotNull()
            {
                var converter = new WebhookNullConverter();
                using var reader = new JsonTextReader(new StringReader("\"Test\""));
                var result = converter.ReadJson(reader, typeof(string), null, JsonSerializer.CreateDefault());
                Assert.Equal("Test", result);
            }
        }

        public class TheWriteJsonMethod
        {
            [Fact]
            public void SerializesObjectCorrectly()
            {
                var webhookResponse = new WebhookResponse<WebhookOrganization>
                {
                    V = 2,
                    Current = null,
                    Previous = null
                };

                var json = JsonConvert.SerializeObject(webhookResponse);

                Assert.Contains("\"v\":2", json);
                Assert.Contains("\"current\":null", json);
                Assert.Contains("\"previous\":null", json);
            }

            [Fact]
            public void SerializesObjectWithNonNullPropertiesCorrectly()
            {
                var organization = new WebhookOrganization { Id = 1, Name = "TestOrg" };
                var webhookResponse = new WebhookResponse<WebhookOrganization>
                {
                    V = 3,
                    Current = organization,
                    Previous = null
                };

                var json = JsonConvert.SerializeObject(webhookResponse);

                var jsonObject = JObject.Parse(json);
                Assert.NotNull(jsonObject);
                Assert.Equal(3, jsonObject["v"]?.Value<int>());
                Assert.Equal(1, jsonObject["current"]?["Id"]?.Value<int>());
                Assert.Equal("TestOrg", jsonObject["current"]?["name"]?.Value<string>());
                Assert.Null(jsonObject["previous"]?.Value<WebhookOrganization>());
            }

            [Fact]
            public void WritesNullWhenValueIsNull()
            {
                var converter = new WebhookNullConverter();
                var stringWriter = new StringWriter();
                var jsonWriter = new JsonTextWriter(stringWriter);
                converter.WriteJson(jsonWriter, null, JsonSerializer.CreateDefault());
                Assert.Equal("null", stringWriter.ToString());
            }

            [Fact]
            public void SerializesValueWhenValueIsNotNull()
            {
                var converter = new WebhookNullConverter();
                var testObject = new { Name = "Test" };
                var stringWriter = new StringWriter();
                var jsonWriter = new JsonTextWriter(stringWriter);
                converter.WriteJson(jsonWriter, testObject, JsonSerializer.CreateDefault());
                var result = stringWriter.ToString();
                Assert.Contains("\"Name\":\"Test\"", result);
            }
        }
    }
}
