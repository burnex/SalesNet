using System;
using SalesNet.Shared.Responses;

namespace SalesNet.Server.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string servicePrefix, string controller);
    }
}

