using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toon.Api.DataContracts;
using Toon.Api.DataContracts.DataAttributes;
using Toon.Api.Enums;
using Toon.Api.Helpers;

namespace Toon.Api.Mocks
{
    public class MockedData
    {
        /*  private static GraphData _data;

          static GraphData data
          {
              get
              {
                  if (_data == null)
                  {
                      var startDate = DateTime.Now.AddDays(-7);
                      _data = new GraphData();
                      _data.Hours = new Dictionary<long, string>();
                      Random r = new Random();
                      int minutes = 30;

                      for (int i = 1; i < 2500; i++)
                      {
                          var multiplier = i * minutes;
                          var dateAsLong = startDate.AddMinutes(multiplier);

                          var value = r.Next(90, 150).ToString();

                          _data.Hours.Add(dateAsLong.ToUnixTime(), value);
                      }
                  }

                  return _data;
                
              }
          }
          */

        public static Boolean TemperatureChanged = true;

        public static ThermostatInfo CurrentThermostatInfo = new ThermostatInfo()
        {
            ActiveState = ThermostatState.Away,
            CurrentDisplayTemperature = 2000,
            CurrentSetpoint = 2100,
            ProgramState = ProgramState.BaseScheme,
            NextProgram = ProgramState.BaseScheme,
            BurnerInfo = Api.Enums.BurnerInfo.Heating,
            NextState = ThermostatState.Sleep,
            CurrentTemp = 2000,
        };

        public static ThermostatStates CurrentThermoStatStates = new ThermostatStates()
                {
                    States = new State[]
                  {
                     new State(){
                          ThermostatState = ThermostatState.Relax,
                          Temperature=2000,
                          Dhw=1
                      },
                      new State(){
                          ThermostatState = ThermostatState.Sleep,
                          Temperature=1500,
                          Dhw=1
                      },
                      new State(){
                          ThermostatState = ThermostatState.Active,
                          Temperature=1800,
                          Dhw=1
                      },
                      new State(){
                          ThermostatState = ThermostatState.Away,
                          Temperature=1100,
                          Dhw=1
                      }
                  }
                };

        public static ToonStateResponse StateResponse = new ToonStateResponse()
            {
                Success = true,
                ToTime = 1390466400,

                //GraphData = data,

                GraphData = new GraphData
                {
                    Hours = new Dictionary<long, string>(){
                        {1390206900, "90"}, //Values in Watt
                        {1390207200, "58.53"},
                        {1390207500, "66.67"},
                        {1390207800, "90"},
                        {1390208100, "119.77"},
                        {1390208400, "130"},
                        {1390208700, "123.13"},
                        {1390209000, "120.7"},
                        {1390209300, "111.2"},
                        {1390209600, "83.83"},
                        {1390209900, "-1"}, //Indicates there was no measurement (display nothing in graph)
                        {1390210200, "105.07"}
                    }
                },

                GasUsage = new GasUsage
                {
                    AvgValue = 90,
                    AvgDayValue = 70,
                    DayUsage = 85,
                    Value = 120,
                },
                PowerUsage = new PowerUsage
                {
                    Value = 950,
                    AvgValue = 820,
                    AvgDayValue = 4560
                },

                ThermostatProgram = new ThermostatProgram()
                {
                    Schedules = new Schedule[]
                  {
                    new Schedule(){
                        Type="weekly_recurring",
                        StartDayOfWeek=6,
                        StartHour=7,
                        StartMin=0,
                        EndDayOfWeek=0,
                        EndHour=10,
                        EndMin=0,
                        TargetState=1
                    },
                    new Schedule(){
                        Type="weekly_recurring",
                        StartDayOfWeek=6,
                        StartHour=10,
                        StartMin=0,
                        EndDayOfWeek=0,
                        EndHour=13,
                        EndMin=0,
                        TargetState=0
                    },
                    new Schedule(){
                        Type="weekly_recurring",
                        StartDayOfWeek=6,
                        StartHour=13,
                        StartMin=0,
                        EndDayOfWeek=0,
                        EndHour=16,
                        EndMin=0,
                        TargetState=1
                    },
                    new Schedule(){
                        Type="weekly_recurring",
                        StartDayOfWeek=6,
                        StartHour=16,
                        StartMin=0,
                        EndDayOfWeek=0,
                        EndHour=23,
                        EndMin=0,
                        TargetState=1
                    },
                    new Schedule(){
                        Type="weekly_recurring",
                        StartDayOfWeek=5,
                        StartHour=23,
                        StartMin=0,
                        EndDayOfWeek=0,
                        EndHour=7,
                        EndMin=0,
                        TargetState=2
                    }
                  }
                },
                ThermostatStates = CurrentThermoStatStates
            };

        public static ToonStateResponse SetPointStateResponse = new ToonStateResponse()
        {
            Success = true,
            ToTime = 1390466400,
            GraphData = new GraphData
            {
                Hours = new Dictionary<long, string>(){
                        {1390206900, "90"}, //Values in Watt
                        {1390207200, "58.53"},
                        {1390207500, "66.67"},
                        {1390207800, "90"},
                        {1390208100, "119.77"},
                        {1390208400, "130"},
                        {1390208700, "123.13"},
                        {1390209000, "120.7"},
                        {1390209300, "111.2"},
                        {1390209600, "83.83"},
                        {1390209900, "-1"}, //Indicates there was no measurement (display nothing in graph)
                        {1390210200, "105.07"}
                    }
            },
            ThermostatProgram = new ThermostatProgram()
            {
                Schedules = new Schedule[]
                  {
                    new Schedule(){
                        Type="weekly_recurring",
                        StartDayOfWeek=6,
                        StartHour=23,
                        StartMin=0,
                        EndDayOfWeek=0,
                        EndHour=10,
                        EndMin=0,
                        TargetState=2
                    }
                  }
            },
            ThermostatStates = CurrentThermoStatStates,
            ThermostatInfo = CurrentThermostatInfo
        };

        public static ToonStateResponse HueGetDeviceConfigInfoResponse = new ToonStateResponse()
        {
            Success = true,
            DeviceConfigInfo = new DeviceConfigInfo()
            {
                Device = new Device[]{
                        new Device()
                        {
                            DeviceUUID = "-haet-0374:happ_smartplug_1826623C6243A",
                            ZWUuid = "qb2-haet-0374:hdrv_zwave_648D7B72435",
                            DeviceType = "FGWP011",
                            DeviceName = "Hue Lamp 1",
                            FlowGraphUuid = "qb2-haet-0374:hcb_config_17515F7A4243B",
                            QuantityGraphUuid = "qb2-haet-0374:hcb_config_17515CC4B243B",
                            Position = "6",
                            InSwitchAll = "1",
                            InSwitchSchedule = "0",
                            UsageCapable = "1",
                            CurrentState = "1"
                        },
                        new Device()
                        {
                            DeviceUUID = "-haet-0374:happ_smartplug_1826623C6243A",
                            ZWUuid = "qb2-haet-0374:hdrv_zwave_648D7B72435",
                            DeviceType = "FGWP011",
                            DeviceName = "Hue Lamp 2",
                            FlowGraphUuid = "qb2-haet-0374:hcb_config_17515F7A4243B",
                            QuantityGraphUuid = "qb2-haet-0374:hcb_config_17515CC4B243B",
                            Position = "6",
                            InSwitchAll = "1",
                            InSwitchSchedule = "0",
                            UsageCapable = "1",
                            CurrentState = "1"
                        },
                        new Device()
                        {
                            DeviceUUID = "-haet-0374:happ_smartplug_1826623C6243A",
                            ZWUuid = "qb2-haet-0374:hdrv_zwave_648D7B72435",
                            DeviceType = "FGWP011",
                            DeviceName = "Hue Lamp 3",
                            FlowGraphUuid = "qb2-haet-0374:hcb_config_17515F7A4243B",
                            QuantityGraphUuid = "qb2-haet-0374:hcb_config_17515CC4B243B",
                            Position = "6",
                            InSwitchAll = "1",
                            InSwitchSchedule = "0",
                            UsageCapable = "1",
                            CurrentState = "1"
                        }
                    }
            }
        };

        public static ToonStateResponse SmartPlugGetDeviceConfigInfoResponse = new ToonStateResponse()
            {
                Success = true,
                DeviceConfigInfo = new DeviceConfigInfo()
                {
                    Device = new Device[]{
                        new Device()
                        {
                            DeviceUUID = "-haet-0374:happ_smartplug_1826623C6243A",
                            ZWUuid = "qb2-haet-0374:hdrv_zwave_648D7B72435",
                            DeviceType = "FGWP011",
                            DeviceName = "Smart plug",
                            FlowGraphUuid = "qb2-haet-0374:hcb_config_17515F7A4243B",
                            QuantityGraphUuid = "qb2-haet-0374:hcb_config_17515CC4B243B",
                            Position = "6",
                            InSwitchAll = "1",
                            InSwitchSchedule = "0",
                            RgbColor = "000000",
                            CurrentState = "1"
                        }
                    }
                }
            };
    }
}
