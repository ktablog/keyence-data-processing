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

        public const int SimaticRack = 0;
        public const int SimaticSlot = 2;

        private const string _keyenceKeyPrefix = "Keyence";
        private const string _keyenceConnectionTypeKey = _keyenceKeyPrefix + "Connection";
        private const string _keyenceConnectionTypeUsbValue = "usb";
        private const string _keyenceConnectionTypeEthernetValue = "ethernet";
        private const string _keyenceIpKey = _keyenceKeyPrefix + "Ip";
        private const string _keyencePortKey = _keyenceKeyPrefix + "Port";
        private const string _simaticKeyPrefix = "Simatic";
        private const string _simaticIpKey = _simaticKeyPrefix + "Ip";
        private const string _simaticBlockKey = _simaticKeyPrefix + "Block";
        private const string _simaticResultYAddressKey = _simaticKeyPrefix + "ResultYAddress";
        private const string _simaticResultZAddressKey = _simaticKeyPrefix + "ResultZAddress";
        private const string _simaticQualityAddressKey = _simaticKeyPrefix + "QualityAddress";
        private const string _simaticCounterAddressKey = _simaticKeyPrefix + "CounterAddress";

        public static KeyenceConnectionType KeyenceConnectionType { get; set; }
        public static string KeyenceIp { get; set; }
        public static string KeyencePort { get; set; }
        public static string SimaticIp { get; set; }
        public static string SimaticBlock { get; set; }
        public static string SimaticResultYAddress { get; set; }
        public static string SimaticResultZAddress { get; set; }
        public static string SimaticQualityAddress { get; set; }
        public static string SimaticCounterAddress { get; set; }

        public static string configPath
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

            KeyenceConnectionType = KeyenceConnectionType.Usb;
        }


        public static void Load()
        {
            CfgFile cfg = new CfgFile();

            cfg.Load(configPath + Path.DirectorySeparatorChar + _configFileName);

            {
                string txt = cfg.Read(_keyenceConnectionTypeKey).Trim().ToLower();
                switch (txt)
                {
                    case _keyenceConnectionTypeUsbValue:
                        KeyenceConnectionType = KeyenceConnectionType.Usb;
                        break;
                    case _keyenceConnectionTypeEthernetValue:
                        KeyenceConnectionType = KeyenceConnectionType.Ethernet;
                        break;
                }
            }
            KeyenceIp = cfg.Read(_keyenceIpKey).Trim();
            KeyencePort = cfg.Read(_keyencePortKey).Trim();

            SimaticIp = cfg.Read(_simaticIpKey).Trim();
            SimaticBlock = cfg.Read(_simaticBlockKey).Trim();
            SimaticResultYAddress = cfg.Read(_simaticResultYAddressKey).Trim();
            SimaticResultZAddress = cfg.Read(_simaticResultZAddressKey).Trim();
            SimaticQualityAddress = cfg.Read(_simaticQualityAddressKey).Trim();
            SimaticCounterAddress = cfg.Read(_simaticCounterAddressKey).Trim();
        }


        public static void Save()
        {
            try
            {
                if (!Directory.Exists(_configPath))
                {
                    Directory.CreateDirectory(_configPath);
                }

                CfgFile cfg = new CfgFile();

                {
                    string connectionType = "";
                    switch(KeyenceConnectionType)
                    {
                        case KeyenceConnectionType.Usb:
                            connectionType = _keyenceConnectionTypeUsbValue;
                            break;
                        case KeyenceConnectionType.Ethernet:
                            connectionType = _keyenceConnectionTypeEthernetValue;
                            break;
                    }
                    cfg.Write(_keyenceConnectionTypeKey, connectionType);
                }
                cfg.Write(_keyenceIpKey, KeyenceIp);
                cfg.Write(_keyencePortKey, KeyencePort);

                cfg.Write(_simaticIpKey, SimaticIp);
                cfg.Write(_simaticBlockKey, SimaticBlock);
                cfg.Write(_simaticResultYAddressKey, SimaticResultYAddress);
                cfg.Write(_simaticResultZAddressKey, SimaticResultZAddress);
                cfg.Write(_simaticQualityAddressKey, SimaticQualityAddress);
                cfg.Write(_simaticCounterAddressKey, SimaticCounterAddress);

                cfg.Save(_configPath + Path.DirectorySeparatorChar + _configFileName);
            }
            catch
            {
            }
        }
    }
}
