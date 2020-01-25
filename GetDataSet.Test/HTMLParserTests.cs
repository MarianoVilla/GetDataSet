using GetDataSet.Lib;
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
    //TODO: test with actual Mendeley result.
    [TestFixture]
    public class HTMLParserTests
    {
        #region Helpers and extractions.
        IEnumerable<HtmlNode> GetNode(string NodeName, RepoFiles HTMLFile)
        {
            string RawHTML = Repo.GetTestHTML(HTMLFile);
            return HTMLParser.GetNodesByName(RawHTML, NodeName);
        }
        IEnumerable<HtmlNode> GetNodeById(string Id, RepoFiles HTMLFile)
        {
            string RawHTML = Repo.GetTestHTML(HTMLFile);
            return HTMLParser.GetNodeById(RawHTML, Id);
        }
        #endregion

        #region Simple HTML tests.
        [Test]
        public void TestGetNode_NoNode()
        {
            Assert.AreEqual(GetNode("SomeInexistentNode", RepoFiles.SimpleHTML).Count(), 0);
            Assert.AreEqual(GetNode("SomeInexistentNode", RepoFiles.MendeleyMusicSearch).Count(), 0);
        }
        [Test]
        public void TestGetNode_SingleNode()
        {
            var Actual = GetNode("h1", RepoFiles.SimpleHTML);

            Assert.AreEqual(Actual.Count(), 1);
            Assert.AreEqual(Actual.First().Name, "h1");

            Actual = GetNode("h1", RepoFiles.MendeleyMusicSearch);

            Assert.AreEqual(Actual.Count(), 0);
        }
        [Test]
        public void TestGetNode_MultipleNodes()
        {

            var Actual = GetNode("p", RepoFiles.SimpleHTML);

            Assert.AreEqual(Actual.Count(), 2);
            Assert.AreEqual(Actual.First().Name, "p");
        }
        [Test]
        public void TestGetNodeById_MultipleNodes()
        {
            var Actual = GetNodeById("Hello", RepoFiles.SimpleHTML);

            Assert.AreEqual(Actual.Count(), 1);
            Assert.AreEqual(Actual.First().Id, "Hello");
        }
        #endregion
    }
}
