using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;

namespace KeyenceDataProcessing
{
    class CfgFile
    {
        #region Field
        private Dictionary<string, string> _dictionary = new Dictionary<string,string>();
        #endregion

        #region Method

        void Clear()
        {
            _dictionary.Clear();
        }
       

        public void Load(string fileName)
        {
            try
            {
                String text;
                using (StreamReader reader = new StreamReader(fileName, Encoding.UTF8))
                {
                    text = reader.ReadToEnd();
                }
                string[] lines = text.Split(new string[] {Environment.NewLine},
                                            StringSplitOptions.RemoveEmptyEntries);
                foreach (string scanLine in lines)
                {
                    int index = scanLine.IndexOf('=');
                    if (index > 0)
                    {
                        string key = scanLine.Substring(0, index).Trim();
                        string value = scanLine.Substring(index + 1).Trim();
                        Write(key, value);
                    }
                }
            }
            catch
            {
            }
        }


        public void Save(string fileName)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<string, string> pair in _dictionary)
            {
                stringBuilder.Append(pair.Key)
                             .Append("=")
                             .Append(pair.Value)
                             .Append(Environment.NewLine);                
            }

            byte[] textData = Encoding.UTF8.GetBytes(stringBuilder.ToString());

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                stream.Write(textData, 0, textData.Length);
            }
        }


        public void Write(string key, string value)
        {
            _dictionary[key] = value;
        }


        public void Write(string key, bool value)
        {
            Write(key, value.ToString(CultureInfo.InvariantCulture));
        }


        public void Write(string key, int value)
        {
            Write(key, value.ToString(CultureInfo.InvariantCulture));
        }


        public void Write(string key, double value)
        {
            Write(key, value.ToString(CultureInfo.InvariantCulture));
        }


        public string Read(string key, string defValue)
        {
            string result = defValue;
            try
            {
                result = _dictionary[key];
            }
            catch
            {
            }
            return result;
        }


        public string Read(string key)
        {
            return Read(key, "");
        }


        public bool Read(string key, bool defValue)
        {
            bool result = defValue;
            try
            {
                result = Boolean.Parse(Read(key, ""));
            }
            catch
            {
            }
            return result;
        }


        public int Read(string key, int defValue)
        {
            int result = defValue;
            try
            {
                result = Int32.Parse(Read(key, ""), CultureInfo.InvariantCulture);
            }
            catch
            {
            }
            return result;
        }


        public double Read(string key, double defValue)
        {
            double result = defValue;
            try
            {
                result = Double.Parse(Read(key, ""), CultureInfo.InvariantCulture);
            }
            catch
            {
            }
            return result;
        }
        #endregion
    }
}


