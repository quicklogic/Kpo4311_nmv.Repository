using System.Configuration;

namespace Kpo4311_hnv.Utility
{
    class AppConfigUtility
    {

        public string AppSettings(string name)
        {
            if (ConfigurationManager.AppSettings != null)
            {
                return ConfigurationManager.AppSettings[name];
            }
            else return "";
        }
    }
}
