using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Toon.Api.Helpers;
using Windows.Security.Credentials;

namespace Toon.Api.Clients
{
    public class AuthenticationClient : IAuthenticationClient
    {
        protected string _token;
        
        protected const string _vaultName = "toon";
        protected const string _vaultUsername = "user";

        public event EventHandler SignedOut;
        public event EventHandler SignedIn;

        public AuthenticationClient()
        {
        }

        protected void RaiseOnSignedIn()
        {
            if (SignedIn != null)
                SignedIn(this, new EventArgs());
        }

        protected void RaiseOnSignedOut()
        {
            if (SignedOut != null)
                SignedOut(this, new EventArgs());
        }

        public virtual async Task<string> Authenticate()
        {
            return String.Empty;
        }

        public async Task<bool> CachedAuthenticate()
        {
            if (await IsUserAuthenticated())
            {
                RaiseOnSignedIn();
                return true;
            }

            return false;
        }

        public void SignOut()
        {
            _token = null;
            DeleteToken();

            if (SignedOut != null)
                RaiseOnSignedOut();
        }

        protected async Task<bool> IsTokenValid(string token)
        {
            HttpClient client = new HttpClient();
            client.Timeout = new TimeSpan(0, 0, 30);
            string url = "https://api-tst.quby.nl:8243/toon/api/v1.0/getElecFlowData?fromTime=" + DateTime.Now.ToUnixTime();

            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Add("Authorization", "Bearer " + token);
            requestMessage.Headers.Add("Cache-Control", "no-cache");

            var response = await client.SendAsync(requestMessage);

            return response.StatusCode != HttpStatusCode.Unauthorized;

            /*if (response != null)
            {
                var responseObject = await Task.Factory.StartNew(() => Newtonsoft.Json.JsonConvert.DeserializeObject<GeneralServiceInformation>(response));

                //Check if the current token contains all the scopes we require in the app
                if (responseObject == null || responseObject.token == null || responseObject.token.authorization == null || responseObject.token.authorization.scopes == null || !TokenContainsRequiredScopes(responseObject.token.authorization.scopes))
                    return false;

                if (responseObject.token.valid != null)
                    return responseObject.token.valid.Value;
                else
                    return false;
            }
            return true;*/
        }

        public Dictionary<string, string> GetHttpAuthenticationHeader()
        {
            if (String.IsNullOrEmpty(_token))
                throw new Exception("User is not logged in");

            return GetHttpAuthenticationHeader(_token);
        }

        protected Dictionary<string, string> GetHttpAuthenticationHeader(string token)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", "Bearer " + token);
            return headers;
        }

        protected void SaveToken()
        {
            PasswordVault vault = new PasswordVault();
            PasswordCredential credential = new PasswordCredential(
                _vaultName,
                _vaultUsername,
                _token);

            vault.Add(credential);
        }

        protected void DeleteToken()
        {
            PasswordVault vault = new PasswordVault();

            try
            {
                PasswordCredential credential = vault.Retrieve(_vaultName, _vaultUsername);
                vault.Remove(credential);
            }
            catch
            {

            }
        }

        protected string LoadToken()
        {
            if (!String.IsNullOrEmpty(_token))
            {
                
                return _token;
            }

            PasswordVault vault = new PasswordVault();
            try
            {
                PasswordCredential credential = vault.Retrieve(_vaultName, _vaultUsername);

                if (!String.IsNullOrEmpty(credential.Password))
                {
                    _token = credential.Password;
                    return _token;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        public string GetToken()
        {
            LoadToken();

            if (!String.IsNullOrEmpty(_token))
            {
                return _token;
            }
            else
                throw new Exception("User is not authenticated");
        }

        public async Task<bool> IsUserAuthenticated()
        {
            LoadToken();

            if (!String.IsNullOrEmpty(_token))
            {
                return await IsTokenValid(_token);
            }

            this.SignOut();
            return false;
        }
    }
}
