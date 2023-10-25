using Core.Utils;

namespace Test_Automation_Project.WebDriver
{
    public static class DriverParameterReader
    {
        private static string driverConfigPath = $"{Environment.CurrentDirectory}/resources";
        private static string driverConfigName = "driverConfig.json";

        public static string Get(string parameter)
        {
            return JsonReader.ReadParameter(driverConfigPath, driverConfigName, parameter);
        }
    }
}
