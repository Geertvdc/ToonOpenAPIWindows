using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Toon.Api.DataContracts;
using Toon.Api.DataContracts.DataAttributes;
using Toon.Api.Enums;
using Toon.Api.Helpers;


namespace Toon.Api.Clients
{
    public class ApiClient : IApiClient
    {
        private IAuthenticationClient _authenticationClient;

        private string Token
        {
            get { return _authenticationClient.GetToken(); }
        }

        public ApiClient(IAuthenticationClient authenticationClient)
        {
            _authenticationClient = authenticationClient;
        }

        #region Helpers

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.Timeout = new TimeSpan(0, 0, 30);
            return client;
        }

        private HttpRequestMessage GetBaseRequest(HttpMethod method, string url)
        {
            var requestMessage = new HttpRequestMessage(method, url);

            requestMessage.Headers.Add("Authorization", "Bearer " + Token);
            requestMessage.Headers.Add("Cache-Control", "no-cache");

            return requestMessage;
        }

        private void ValidateResponse(HttpResponseMessage response)
        {
            if (HttpStatusCode.OK != response.StatusCode)
            {
                throw new Exception("Something went wrong: ");
            }
        }

        #endregion

        public async Task<ToonStateResponse> GetToonState()
        {
            var client = GetClient();
            var requestMessage = GetBaseRequest(HttpMethod.Get,
                String.Format("{0}/toon/api/v1.0/retrieveToonState", Constants.ApiUrl));

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        public async Task<ToonStateResponse> GetElecFlowData(DateTime? fromDate)
        {
            var client = GetClient();

            string url = "https://api-tst.quby.nl:8243/toon/api/v1.0/getElecFlowData";
            if (fromDate.HasValue)
                url += "?fromTime=" + fromDate.Value.ToUnixTime();

            var requestMessage = GetBaseRequest(HttpMethod.Get, url);

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        public async Task<ToonStateResponse> GetThermostatProgram()
        {
            var client = GetClient();
            var requestMessage = GetBaseRequest(HttpMethod.Get,
                "https://api-tst.quby.nl:8243/toon/api/v1.0/retrieveThermostatProgram");

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        public async Task<ToonStateResponse> SchemeState(ProgramState programState, ThermostatState thermostatState)
        {
            //todo: add post message?
            var client = GetClient();
            var requestMessage = GetBaseRequest(HttpMethod.Post,
                "https://api-tst.quby.nl:8243/toon/api/v1.0/schemeState");

            var values = new Dictionary<string, string>
			{
				{ "state", JsonConvert.SerializeObject(programState) },       
				{ "temperatureState", JsonConvert.SerializeObject(thermostatState) },       
			};
            requestMessage.Content = new FormUrlEncodedContent(values);

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        public async Task<ToonStateResponse> SetPoint(double value)
        {
            //todo: add post message?
            var client = GetClient();
            var requestMessage = GetBaseRequest(HttpMethod.Post,
                "https://api-tst.quby.nl:8243/toon/api/v1.0/setPoint");

            var values = new Dictionary<string, string>
			{
				{ "value", Math.Round(value * 100).ToString() },       
			};
            requestMessage.Content = new FormUrlEncodedContent(values);

            var response = await client.SendAsync(requestMessage);

            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        public async Task<ToonStateResponse> SetSmartplugTarget(string Uuid, bool state)
        {
            var client = GetClient();
            var requestMessage = GetBaseRequest(HttpMethod.Post,
                "https://api-tst.quby.nl:8243/toon/api/v1.0/smartplug/setTarget");

            var values = new Dictionary<string, string>();
            values.Add("devUuid", Uuid);
            values.Add("state", state ? "1" : "0");

            requestMessage.Content = new FormUrlEncodedContent(values);

            var response = await client.SendAsync(requestMessage);

            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        public async Task<ToonStateResponse> GetHueDeviceConfigInfo()
        {
            var client = GetClient();
            var requestMessage = GetBaseRequest(HttpMethod.Get,
                "https://api-tst.quby.nl:8243/toon/api/v1.0/hue/getDeviceConfigInfo");

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        public async Task<ToonStateResponse> GetSmartPlugDeviceConfigInfo()
        {
            var client = GetClient();
            var requestMessage = GetBaseRequest(HttpMethod.Get,
                "https://api-tst.quby.nl:8243/toon/api/v1.0/smartplug/getDeviceConfigInfo");

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }


        /// <summary>
        /// Use the FILLED Uuid from the datacontract.
        /// </summary>
        /// <param name="Uuid">The UUID.</param>
        /// <param name="fromDate">From date.</param>
        /// <returns></returns>
        public async Task<ToonStateResponse> GetSmartPlugGraphFlowData(string Uuid, DateTime? fromDate)
        {
            var client = GetClient();

            // Uuid = "plug_elec_flow_7554873EB21";

            string url = "https://api-tst.quby.nl:8243/toon/api/v1.0/smartplug/getFlowData?devUuid=" + Uuid;

            if (fromDate.HasValue)
                url += "&fromTime=" + fromDate.Value.ToUnixTime();

            var requestMessage = GetBaseRequest(HttpMethod.Get, url);

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }

        /// <summary>
        /// I have no idea what this does. But Use the FILLED Uuid from the datacontract.
        /// </summary>
        /// <param name="Uuid">The UUID.</param>
        /// <param name="fromDate">From date.</param>
        /// <returns></returns>
        public async Task<ToonStateResponse> GetSmartPlugGraphQuantityData(string Uuid, DateTime? fromDate)
        {
            var client = GetClient();

            //Uuid = "plug_elec_qtty_7554873EB21";

            string url = "https://api-tst.quby.nl:8243/toon/api/v1.0/smartplug/getGraphData?devUuid=" + Uuid;

            if (fromDate.HasValue)
                url += "&fromTime=" + fromDate.Value.ToUnixTime();

            var requestMessage = GetBaseRequest(HttpMethod.Get, url);

            var response = await client.SendAsync(requestMessage);
            ValidateResponse(response);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ToonStateResponse>(content);
        }
    }
}
