using System.Configuration;

namespace SpecFlowProject2.Utilities
{
    public static class ConfigurationReader
    {
        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}