using System.Collections.Generic;
using System.Threading.Tasks;
using Net.Pipedrive.Internal;
using NSubstitute;
using Xunit;

namespace Net.Pipedrive.Tests.Http
{
    public class ReadOnlyPagedCollectionTests
    {
        public class TheConstructor
        {
            [Fact]
            public void AcceptsAResponseWithANullBody()
            {
                var response = Substitute.For<IApiResponse<JsonResponse<List<string>>>>();
                response.Body.Returns((JsonResponse<List<string>>)null);

                var exception = Record.Exception(() =>
                    new ReadOnlyPagedCollection<string>(response, uri => Task.FromResult(response)));

                Assert.Null(exception);
            }
        }
    }
}
