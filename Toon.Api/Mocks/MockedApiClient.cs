using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Toon.Api.Clients;
using Toon.Api.DataContracts;
using Toon.Api.DataContracts.DataAttributes;
using Toon.Api.Enums;
using System.Linq;

namespace Toon.Api.Mocks
{
    public class MockedApiClient : IApiClient
    {
        // Suppress warning 1998 This async method lacks 'await' for mockup functionality
#pragma warning disable 1998

        public async Task<ToonStateResponse> GetToonState()
        {
            ToonStateResponse response = MockedData.StateResponse;

            if(MockedData.TemperatureChanged)
            {
                response = MockedData.SetPointStateResponse;
                MockedData.TemperatureChanged = false;
            }

            return response;
        }

        public async Task<ToonStateResponse> GetElecFlowData(DateTime? fromDate = null)
        {
            return MockedData.StateResponse;
        }

        public async Task<ToonStateResponse> GetThermostatProgram()
        {
            return MockedData.StateResponse;
        }

        public async Task<ToonStateResponse> SchemeState(ProgramState programState, ThermostatState thermostatState)
        {
            MockedData.SetPointStateResponse.ThermostatInfo.ProgramState = programState;
            MockedData.SetPointStateResponse.ThermostatInfo.ActiveState = thermostatState;

            var newState = MockedData.CurrentThermoStatStates.States.Where(s => s.ThermostatState == thermostatState).SingleOrDefault();

            if(newState != null)
            {
                MockedData.SetPointStateResponse.ThermostatInfo.CurrentSetpoint = newState.Temperature;
                MockedData.TemperatureChanged = true;
            }

            return MockedData.SetPointStateResponse;
        }

        public async Task<ToonStateResponse> SetPoint(double value)
        {
            MockedData.SetPointStateResponse.ThermostatInfo.CurrentSetpoint = value * 100;
            MockedData.SetPointStateResponse.ThermostatInfo.BurnerInfo = MockedData.SetPointStateResponse.ThermostatInfo.CurrentSetpoint >= MockedData.SetPointStateResponse.ThermostatInfo.CurrentDisplayTemperature ? BurnerInfo.Heating : BurnerInfo.Cooling;

            MockedData.TemperatureChanged = true;

            return MockedData.SetPointStateResponse;
        }

        public async Task<ToonStateResponse> SetSmartplugTarget(string Uuid, bool state)
        {
            return MockedData.StateResponse;
        }

        public async Task<ToonStateResponse> GetSmartPlugDeviceConfigInfo()
        {
            return MockedData.SmartPlugGetDeviceConfigInfoResponse;
        }

        public async Task<ToonStateResponse> GetHueDeviceConfigInfo()
        {
            return MockedData.HueGetDeviceConfigInfoResponse;
        }

#pragma warning restore 1998



        public Task<ToonStateResponse> GetSmartPlugGraphFlowData(string Uuid, DateTime? fromDate = null)
        {
            throw new NotImplementedException();
        }

        public Task<ToonStateResponse> GetSmartPlugGraphQuantityData(string Uuid, DateTime? fromDate = null)
        {
            throw new NotImplementedException();
        }
    }
}