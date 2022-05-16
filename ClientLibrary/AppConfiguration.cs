using ClientLibrary.Model;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ClientLibrary
{
    public static class AppConfiguration
    {
        public static AppConfigurationData appConfigurationSettings;
        /// <summary>
        /// Load Configuration
        /// </summary>
        static AppConfiguration()
        {
            LoadConfiguration();
        }
        /// <summary>
        /// Method to load configuration
        /// </summary>
        public static void LoadConfiguration()
        {
            try
            {
                var jsonFileData = ReadJsonFileData();
                appConfigurationSettings = JsonConvert.DeserializeObject<AppConfigurationData>(jsonFileData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Method to read json file
        /// </summary>
        /// <returns></returns>
        public static string ReadJsonFileData()
        {
            try
            {
                string text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/AppSetting.json");
                return text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}