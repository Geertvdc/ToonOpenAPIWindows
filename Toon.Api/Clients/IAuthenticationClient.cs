using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Toon.Api.Clients
{
    public interface IAuthenticationClient
    {
        Task<string> Authenticate();
        Task<bool> CachedAuthenticate();
        void SignOut();
        Dictionary<string,string> GetHttpAuthenticationHeader();
        string GetToken();
        Task<bool> IsUserAuthenticated();
        event EventHandler SignedOut;
        event EventHandler SignedIn;
    }
}
