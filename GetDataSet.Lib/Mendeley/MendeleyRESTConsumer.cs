using GetDataSet.Lib.GeneralLib;
using GetDataSet.Lib.ScrapLib;
using GetDataSet.Model.Mendeley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Lib.Mendeley
{
    public class MendeleyRESTConsumer
    {
        static string MendeleyInnerAPI = "https://data.mendeley.com/api/public_datasets_search";
        public static List<MendeleyJSONResult> Search(string Query, MendeleyDataType[] Types = null, int? Page = null)
        {
            string URL = $"{MendeleyInnerAPI}?query={Query.URLEncoded()}&page={Page}&{Types.Parse()}";
            return HTTPHandler.GetJSON<MendeleyJSONRootObject>(URL).results;
        }
    }
}
