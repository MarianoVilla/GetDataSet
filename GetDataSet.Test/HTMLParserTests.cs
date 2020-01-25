using GetDataSet.Lib.ScrapLib;
using GetDataSet.Test.TestRepo;
using HtmlAgilityPack;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataSet.Test
{
    [TestFixture]
    public class HTMLParserTests
    {
        #region Helpers and extractions.
        IEnumerable<HtmlNode> GetNode(string NodeName, RepoFiles HTMLFile)
        {
            string RawHTML = GetTestHTML(HTMLFile);
            return HTMLParser.GetNodesByName(RawHTML, NodeName);
        }
        IEnumerable<HtmlNode> GetNodeById(string Id, RepoFiles HTMLFile)
        {
            string RawHTML = GetTestHTML(HTMLFile);
            return HTMLParser.GetNodeById(RawHTML, Id);
        }
        IEnumerable<HtmlNode> GetNodeByClass(RepoFiles HTMLFile, params string[] Classes)
        {
            string RawHTML = GetTestHTML(HTMLFile);
            return HTMLParser.GetNodesByClass(RawHTML, Classes);
        }
        string GetTestHTML(RepoFiles HTMLFile)
            => Repo.GetTestHTML(HTMLFile);

        #endregion
        [Test]
        public void TestGetNode_NoNode()
        {
            Assert.AreEqual(0, GetNode("SomeInexistentNode", RepoFiles.SimpleHTML).Count());
            Assert.AreEqual(0, GetNode("SomeInexistentNode", RepoFiles.MendeleyMusicSearch).Count());
        }
        [Test]
        public void TestGetNode_SingleNode()
        {
            var Actual = GetNode("h1", RepoFiles.SimpleHTML);

            Assert.AreEqual(1, Actual.Count());
            Assert.AreEqual("h1", Actual.First().Name);

            Assert.AreEqual(0, GetNode("h1", RepoFiles.MendeleyMusicSearch).Count());
            Assert.AreEqual(1, GetNode("script", RepoFiles.MendeleyMusicSearchStripped).Count());
        }
        [Test]
        public void TestGetNode_MultipleNodes()
        {

            var Actual = GetNode("p", RepoFiles.SimpleHTML);

            Assert.AreEqual(2, Actual.Count());
            Assert.AreEqual("p", Actual.First().Name);
        }
        [Test]
        public void TestGetNodeById_MultipleNodes()
        {
            var Actual = GetNodeById("Hello", RepoFiles.SimpleHTML);

            Assert.AreEqual(1, Actual.Count());
            Assert.AreEqual("Hello", Actual.First().Id);
        }
        [Test]
        public void TestGetNodeByClass_NoNode()
        {
            var Actual = GetNodeByClass(RepoFiles.SimpleHTML, "SomeInexistantClass");

            Assert.AreEqual(0, Actual.Count());

            Actual = GetNodeByClass(RepoFiles.MendeleyMusicSearchStripped, "SomeInexistantClass");
            Assert.AreEqual(0, Actual.Count());
        }
        [Test]
        public void TestGetNodeByClass_SingleNode()
        {
            var Actual = GetNodeByClass(RepoFiles.SimpleHTML, "Hello");
            Assert.AreEqual(1, Actual.Count());

            Actual = GetNodeByClass(RepoFiles.MendeleyMusicSearchStripped, "public-datasets-search__results");
            Assert.AreEqual(1, Actual.Count());
        }
        [Test]
        public void TestGetNodeByClass_MultipleNodes()
        {
            var Actual = GetNodeByClass(RepoFiles.MendeleyMusicSearch, "search-result__header-text");
            //Mendeley always returns 10 results at most.
            Assert.AreEqual(10, Actual.Count());
        }
    }
}
