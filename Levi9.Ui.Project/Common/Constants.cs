using System.Collections.Generic;
using System.Configuration;

namespace Levi9.Ui.Project.Common
{
    public static class Constants
    {
        //this is a class that is used to retrieve settings from App.config file
        public static string GetAppSetting(string key)
        {
            var setting = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(setting))
            {
                ;
                var error = $"[{key}] key is not defined in App*.Config files";

                throw new KeyNotFoundException(error);
            }

            return setting;
        }

        public static string baseUrl => GetAppSetting("BaseUrl");
        public static string standardUser => GetAppSetting("standardUsername");
        public static string performanceUser => GetAppSetting("performanceUsername");
        public static string password => GetAppSetting("password");

        // constants

        public const int NUMBER_OF_SECONDS_10 = 10;
        public const int NUMBER_OF_SECONDS_5 = 5;
        public const string NUMBER_OF_INSERTIONS_1 = "1";
    }
}