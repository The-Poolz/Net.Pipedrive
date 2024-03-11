using Net.Pipedrive.Webhooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Net.Pipedrive.Tests.Converters
{
    public class WebhookNullConverterTests
    {
        public class TheReadJsonMethod
        {
            [Fact]
            public void DeserializesObjectCorrectly()
            {
                var json = "{ \"v\": 1, \"current\": null, \"previous\": null }";
                var result = JsonConvert.DeserializeObject<WebhookResponse<WebhookOrganization>>(json);

                Assert.NotNull(result);
                Assert.Equal(1, result.V);
                Assert.Null(result.Current);
                Assert.Null(result.Previous);
            }

            [Fact]
            public void DeserializesNonExistingPropertiesAsNull()
            {
                var json = "{ \"v\": 1 }";
                var result = JsonConvert.DeserializeObject<WebhookResponse<WebhookOrganization>>(json);

                Assert.NotNull(result);
                Assert.Equal(1, result.V);
                Assert.Null(result.Current);
                Assert.Null(result.Previous);
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
                Assert.Equal("TestOrg", jsonObject["current"]?["Name"]?.Value<string>());
                Assert.Null(jsonObject["previous"]?.Value<WebhookOrganization>());
            }
        }
    }
}
