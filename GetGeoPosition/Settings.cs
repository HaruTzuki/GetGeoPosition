using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGeoPosition
{
    static public class Settings
    {
        /// <summary>
        /// Url of API Link
        /// </summary>
        static public string url;
        /// <summary>
        /// Google API Key
        /// </summary>
        static public string api_key;
        /// <summary>
        /// Path to save.
        /// </summary>
        static private string FilePath = AppDomain.CurrentDomain.BaseDirectory+@"\values.txt";

        /// <summary>
        /// Save Settings Method
        /// </summary>
        static public void SaveSettings()
        {
            CheckPaths();
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(url);
                sw.WriteLine(api_key);
                sw.Close();
            }
        }

        /// <summary>
        /// Load Saved Settings Method
        /// </summary>
        static public void LoadSettings()
        {
            CheckPaths();
            using (StreamReader sr = new StreamReader(FilePath))
            {
                url = sr.ReadLine();
                api_key = sr.ReadLine();
                sr.Close();
            }
        }

        /// <summary>
        /// Checking the File if exists.
        /// </summary>
        private static void CheckPaths()
        {
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
        }
    }
}
