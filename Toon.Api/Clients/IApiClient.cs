using System;
using System.Threading.Tasks;
using Toon.Api.DataContracts;
using Toon.Api.DataContracts.DataAttributes;
using Toon.Api.Enums;

namespace Toon.Api.Clients
{
    public interface IApiClient
    {
        Task<ToonStateResponse> GetToonState();
        Task<ToonStateResponse> GetElecFlowData(DateTime? fromDate = null);
        Task<ToonStateResponse> GetThermostatProgram();
        Task<ToonStateResponse> SchemeState(ProgramState programState, ThermostatState thermostatState);
        Task<ToonStateResponse> SetPoint(double value);
        Task<ToonStateResponse> SetSmartplugTarget(string Uuid, bool state);
        Task<ToonStateResponse> GetHueDeviceConfigInfo();
        Task<ToonStateResponse> GetSmartPlugDeviceConfigInfo();

        Task<ToonStateResponse> GetSmartPlugGraphFlowData(string Uuid, DateTime? fromDate = null);
        Task<ToonStateResponse> GetSmartPlugGraphQuantityData(string Uuid, DateTime? fromDate = null);
    }
}