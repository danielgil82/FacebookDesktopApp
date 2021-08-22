using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookAppLogic
{
    public sealed class AppSettings
    {
        private const string k_AppSettingsFilePath = @"AppSettings.xml";
        private static AppSettings s_TheOneAndOnlyInstance = null;
         
        public bool RememberUser { get; set; }

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public string LastAccessToken { get; set; }

        static AppSettings() { }

        private AppSettings()
        {
            LastWindowSize = new Size(1140, 860);
            LastWindowLocation = new Point(50, 50);
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();

            if (File.Exists(k_AppSettingsFilePath))
            {
                using (Stream stream = new FileStream(k_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }
       
        public static AppSettings GetTheOneOneAndOnlyInstanceOfAppSettings 
        {
            get
            {
                if(s_TheOneAndOnlyInstance == null)
                {
                    s_TheOneAndOnlyInstance = new AppSettings();
                }

                return s_TheOneAndOnlyInstance;
            }
        }

        public void SaveToFile()
        {
            if (File.Exists(k_AppSettingsFilePath))
            {
                using (Stream stream = new FileStream(k_AppSettingsFilePath, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(k_AppSettingsFilePath, FileMode.CreateNew))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }
    }
}
