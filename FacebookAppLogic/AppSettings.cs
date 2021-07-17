﻿using System;
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
      
        private AppSettings()
        {
           LastWindowSize = new Size(1141, 856);
           LastWindowLocation = new Point(50, 50);
           RememberUser = false;
           LastAccessToken = null;
        }

        public bool RememberUser { get; set; }

        public Point LastWindowLocation { get; set; }
     
        public Size LastWindowSize { get; set; }
        
        public string LastAccessToken { get; set; }

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

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();
            //AppSettings obj = null;

            if (File.Exists(k_AppSettingsFilePath))
            {
                using (Stream stream = new FileStream(k_AppSettingsFilePath, FileMode.Open))
                {
                    Console.WriteLine("Test");
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }
    }
}
