using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Lib
{
    public static class ExtensionMethods
    {
        public static string ToDescriptionString<T>(this T val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static string URLEncoded(this string TheString)
            => WebUtility.UrlEncode(TheString);

        public static string Parse(this MendeleyDataType[] Types)
        {
            if (Types == null)
            {
                return MendeleyDataType.Dataset.ToDescriptionString();
            }
            StringBuilder Builder = new StringBuilder();
            foreach (var t in Types)
            {
                Builder.Append("type=" + t.ToDescriptionString() + "&");
            }
            return Builder.ToString(0, Builder.Length - 1);
        }
    }
}
