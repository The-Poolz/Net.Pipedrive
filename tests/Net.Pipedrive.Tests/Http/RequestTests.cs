using Net.Pipedrive.Internal;
using Xunit;

namespace Net.Pipedrive.Tests.Http
{
    public class RequestTests
    {
        public class TheConstructor
        {
            [Fact]
            public void InitializesAllRequiredProperties()
            {
                var r = new Request();

                Assert.NotNull(r.Headers);
            }
        }
    }
}
