using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toon.Api.Clients;

namespace Toon.Api.Mocks
{
    public class MockedAuthenticationClient : IAuthenticationClient
    {
        private static string _token = "MockedToken";

        public async Task<string> Authenticate()
        {
            _token = "MockedToken";
            return String.Empty;
        }

        public async Task<bool> CachedAuthenticate()
        {
            _token = "MockedToken";
            if (SignedIn != null)
                SignedIn(this, new EventArgs());
            return true;
        }

        public void SignOut()
        {
            _token = null;
            if (SignedOut != null)
                SignedOut(this, new EventArgs());
        }

        public Dictionary<string, string> GetHttpAuthenticationHeader()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", "Bearer " + _token);
            return headers;
        }

        public string GetToken()
        {
            return _token;
        }

        public async Task<bool> IsUserAuthenticated()
        {
            return true;
        }

        public event EventHandler SignedOut;

        public event EventHandler SignedIn;
    }
}
