using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using AppFacade = ApplicationLogic.ApplicationFacade;


namespace FacebookWinFormsApp
{
    public class AppSettings
    {
        private Point m_LastFormCoordinates;
        private Size m_LastFormSize;
        private bool m_RememberUser;
        private string m_LastAccesToken;
        private const string k_AppSettingsPath = @"AppSettings.xml";


        public AppSettings()
        {
            m_LastFormCoordinates = new Point(20, 50);
            m_LastFormSize = new Size(500, 500);
            m_RememberUser = false;
            m_LastAccesToken = null;
        }



        public void SaveToFile()
        {


            if (File.Exists(k_AppSettingsPath))
            {
                using (Stream stream = new FileStream(k_AppSettingsPath, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }

            else
            {
                using (Stream stream = new FileStream(k_AppSettingsPath, FileMode.CreateNew)) // using closes the file automatically
                {

                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);

                }
            }

        }

        public static AppSettings LoadFromFile(AppFacade i_FacdeToInit)
        {
            AppSettings appSettings = new AppSettings();

            if (File.Exists(k_AppSettingsPath))
            {
                using (Stream stream = new FileStream(k_AppSettingsPath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            

            return appSettings;
        }


        public Point LastWindowLocation
        {
            get
            {
                return m_LastFormCoordinates;
            }
            set
            {
                m_LastFormCoordinates = value;
            }
        }

        public Size LastWindowSize
        {
            get
            {
                return m_LastFormSize;
            }
            set
            {
                m_LastFormSize = value;
            }
        }

        public bool RememberUser
        {
            get
            {
                return m_RememberUser;
            }


            set
            {
                m_RememberUser = value;
            }
        }

        public string LastAccessToken
        {
            get
            {
                return m_LastAccesToken;
            }
            set
            {
                m_LastAccesToken = value;
            }
        }
    }
}
