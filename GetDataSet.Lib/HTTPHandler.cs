using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Lib
{
    public class HTTPHandler
    {
        //TODO: add an Async API.
        public static string GetHTML(string URL)
        {
            WebRequest Request = WebRequest.Create(URL);
            WebResponse Response = Request.GetResponse();
            using(Stream ResponseStream = Response.GetResponseStream())
            {
                using(StreamReader Reader = new StreamReader(ResponseStream))
                {
                    return Reader.ReadToEnd();
                }
            }
        }
    }
}
