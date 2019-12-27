using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RetropieMetadataEditor.Container
{
    class Library
    {
        public static string Add0(string s)
        {
            if (s.Length == 1)
            {
                return "0" + s;
            }
            else
            {
                return s;
            }
        }

        public static string Add0(string s, int maxSize)
        {
            while (s.Length < maxSize)
            {
                s = "0" + s;
            }

            return s;
        }

        public static string GetFileSize(long fileSize)
        {
            string result = fileSize + " Byte";
            decimal size = fileSize;

            if (size >= 1024)
            {
                size = size / 1024;
                result = Math.Round(size, 2) + " KB";
            }

            if (size >= 1024)
            {
                size = size / 1024;
                result = Math.Round(size, 2) + " MB";
            }

            if (size >= 1024)
            {
                size = size / 1024;
                result = Math.Round(size, 2) + " GB";
            }

            return result;
        }

        public static DateTime ParseDatetime(string dtString)
        {
            DateTime result = DateTime.MinValue;
            dtString = dtString.Trim();
            if (dtString != null && dtString != string.Empty && dtString != "00000000T000000")
            {
                try
                {
                    result = DateTime.ParseExact(dtString, "yyyyMMddTHHmmss", CultureInfo.InvariantCulture);
                }
                catch { }
            }

            return result;
        }

        public static string GetXmlValue(XmlNode node)
        {
            if (node != null)
            {
                return node.InnerText;
            }
            return string.Empty;
        }
        
    }
}
