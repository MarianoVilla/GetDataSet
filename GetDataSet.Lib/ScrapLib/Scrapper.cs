using GetDataSet.Lib.GeneralLib;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Lib.ScrapLib
{
    public class Scrapper
    {
        /// <summary>
        /// Shortcut to get only the inner text of the nodes from a URL.
        /// </summary>
        /// <param name="URL">The URL from where to get the HTML.</param>
        /// <param name="NodeNames">The node(s) with which we'll filter the result.</param>
        /// <returns>An enumerable of strings, representing the inner text of the retrieved nodes.</returns>
        public static IEnumerable<string> GetNodesTextFromURLByName(string URL, params string[] NodeNames)
        {
            return GetNodesFromURLByName(URL, NodeNames).Select(x => x.InnerText);
        }
        /// <summary>
        /// Gets a collection of nodes from a URL, searching by tag name.
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="NodeNames"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetNodesFromURLByName(string URL, params string[] NodeNames)
        {
            string RawHTML = HTTPHandler.GetString(URL);
            return HTMLParser.GetNodesByName(RawHTML, NodeNames);
        }
        /// <summary>
        /// Gets a collection of nodes from a URL, searching by class name.
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="Classes"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetNodesFromURLByClass(string URL, params string[] Classes)
        {
            string RawHTML = HTTPHandler.GetString(URL);
            return HTMLParser.GetNodesByClass(RawHTML, Classes);
        }


    }
}
