using GetDataSet.Model.Mendeley;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Lib.GeneralLib
{
    public class HTTPHandler
    {
        //TODO: add an Async API.
        public static string GetString(string URL)
        {
            WebRequest Request = WebRequest.Create(URL);
            WebResponse Response = Request.GetResponse();
            using (Stream ResponseStream = Response.GetResponseStream())
            {
                using (StreamReader Reader = new StreamReader(ResponseStream))
                {
                    return Reader.ReadToEnd();
                }
            }
        }
        public static T GetJSON<T>(string URL)
        {
            string ResponseString = GetString(URL);
            return JsonConvert.DeserializeObject<T>(ResponseString);
        }
    }
}
