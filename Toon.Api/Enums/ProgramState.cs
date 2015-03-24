namespace Toon.Api.Enums
{
    public enum ProgramState
    {
        Undefined = -1,
        ManualControl = 0,
        BaseScheme = 1,
        TemperatureOverride = 2,
        Holiday = 4,
        LockedBaseScheme = 8
    }
}
