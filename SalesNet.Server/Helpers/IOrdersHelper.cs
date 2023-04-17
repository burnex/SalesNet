using SalesNet.Shared.Responses;

namespace SalesNet.Server.Helpers
{
    public interface IOrdersHelper
    {
        Task<Response> ProcessOrderAsync(string email, string remarks);
    }
}
