using System.ComponentModel;

namespace EmpiresInSpace.Enums
{
    public enum Atmosphere
    {
        [Description("Any")] Any,
        [Description("None")] None,
        [Description("Methane")] Methane,
        [Description("Oxygen")] Oxygen,
        [Description("Hydrogen")] Hydrogen,
        [Description("Carbon Dioxide")] CarbonDioxide
    }
}