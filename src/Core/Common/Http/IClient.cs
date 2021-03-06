﻿using System.Threading.Tasks;

namespace Atomiv.Core.Common.Http
{
    public interface IClient
    {
        Task<ClientResponse> GetAsync(string uri, HeaderDictionary headers = null);

        Task<ClientResponse> PostAsync(string uri, string content, HeaderDictionary headers = null);

        Task<ClientResponse> PutAsync(string uri, string content, HeaderDictionary headers = null);

        Task<ClientResponse> DeleteAsync(string uri, HeaderDictionary headers = null);
    }
}