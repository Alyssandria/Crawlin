
namespace Crawler.Tests.Utils;


internal class MockHttpHandler(Func<HttpRequestMessage, HttpResponseMessage> responseHandler) : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        return Task.FromResult(responseHandler(request));
    }
}
