using Net.Pipedrive.Internal;
using Xunit;

namespace Net.Pipedrive.Tests.Http
{
    public class ResponseTests
    {
        public class TheConstructor
        {
            [Fact]
            public void InitializesAllRequiredProperties()
            {
                var r = new Response();

                Assert.NotNull(r.Headers);
            }
        }
    }
}
