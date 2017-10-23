namespace Kpo4311_hnv.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        private static string _dataFileName;

        public static string logPath
        {
            get { return _logPath; }
        }
        public static string dataFileName
        {
            get { return _dataFileName; }
        }
  

        public static void Initialize()
        {
            Utility.AppConfigUtility method = new Utility.AppConfigUtility();

            _logPath = method.AppSettings("logPath");
            _dataFileName = method.AppSettings("dataFileName");
        }
    }

    

}
