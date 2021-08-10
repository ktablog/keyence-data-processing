using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KeyenceDataProcessing
{
    static class Common
    {
        private const string _applicationName = "KeyenceDataProcessing";
        private const string _configFileName = _applicationName + ".config";
        private static string _configPath;

        private const string _keyenceKeyPrefix = "Keyence";
        private const string _keyenceIpKey = _keyenceKeyPrefix + "Ip";
        private const string _keyencePortKey = _keyenceKeyPrefix + "Port";
        private const string _simaticKeyPrefix = "Simatic";
        private const string _simaticIpKey = _simaticKeyPrefix + "Ip";
        private const string _simaticBlockKey = _simaticKeyPrefix + "Block";
        private const string _simaticResultYAddressKey = _simaticKeyPrefix + "ResultYAddress";
        private const string _simaticResultZAddressKey = _simaticKeyPrefix + "ResultZAddress";
        private const string _simaticQualityAddressKey = _simaticKeyPrefix + "QualityAddress";
        private const string _simaticCounterAddressKey = _simaticKeyPrefix + "ConterAddress";
       
        public static string KeyenceIp { get; set; }
        public static string KeyencePort { get; set; }
        public static string SimaticIp { get; set; }
        public static string SimaticBlock { get; set; }
        public static string SimaticResultYAddress { get; set; }
        public static string SimatciResultZAddress { get; set; }
        public static string SimaticQualityAddress { get; set; }
        public static string SimaticCounterAddress { get; set; }

        internal static string configPath
        {
            get
            {
                return _configPath;
            }
        }


        static Common() 
        {
            _configPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                Path.DirectorySeparatorChar + _applicationName;
        }


        internal static void load()
        {
            CfgFile cfg = new CfgFile();

            cfg.Load(configPath + Path.DirectorySeparatorChar + _configFileName);
        }


        internal static void save()
        {
            try
            {
                if (!Directory.Exists(_configPath))
                {
                    Directory.CreateDirectory(_configPath);
                }

                CfgFile cfg = new CfgFile();

                cfg.Save(_configPath + Path.DirectorySeparatorChar + _configFileName);
            }
            catch
            {
            }
        }
    }
}
