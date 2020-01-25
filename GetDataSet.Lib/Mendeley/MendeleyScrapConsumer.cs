using GetDataSet.Lib.ScrapLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Lib.Mendeley
{
    public class MendeleyScrapConsumer
    {
        static string MendeleyURL = @"https://data.mendeley.com/datasets";
        static string SearchResultHeader = "search-result__header-text";
        string SanityCheckURL = "https://data.mendeley.com/datasets?query=musical%20instruments&page=0&type=VIDEO&type=IMAGE";

        //TODO: this should return Mendeley objects instead of the raw. So, parse the HTML.
        public static IEnumerable<string> Search(string Filter, MendeleyDataType[] Types = null)
        {
            string URL = $"{MendeleyURL}?query={WebUtility.UrlEncode(Filter)}&page=0&{Types.Parse()}";
            var result = Scrapper.GetNodesFromURLByClass(URL, SearchResultHeader);
            return null;
        }
    }
}
