using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Lib
{
    public class HTMLParser
    {
        public static List<HtmlNode> GetNodesByName(string RawHTML, params string[] NodeNames)
        {
            List<HtmlNode> Nodes = new List<HtmlNode>();
            var htmlDocument = LoadDocument(RawHTML);

            foreach(var nn in NodeNames)
                Nodes.AddRange(htmlDocument.DocumentNode.Descendants(nn));

            return Nodes;
        }
        public static HtmlDocument LoadDocument(string RawHTML)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(RawHTML);
            return htmlDocument;
        }
        public static List<HtmlNode> GetNodeById(string RawHTML, params string[] NodeNames)
        {
            List<HtmlNode> Nodes = new List<HtmlNode>();
            var htmlDocument = LoadDocument(RawHTML);

            foreach (var nn in NodeNames)
                Nodes.Add(htmlDocument.GetElementbyId(nn));

            return Nodes;
        }
    }
}
