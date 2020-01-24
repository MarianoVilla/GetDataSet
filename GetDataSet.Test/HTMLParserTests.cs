using GetDataSet.Lib;
using GetDataSet.Test.TestRepo;
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
        [Test]
        public void TestGetNode_NoNode()
        {
            string RawHTML = Repo.GetTestHTML(RepoFiles.SimpleHTML);
            var Actual = HTMLParser.GetNodesByName(RawHTML, "SomeInexistentNode");

            Assert.AreEqual(Actual.Count(), 0);
        }
        [Test]
        public void TestGetNode_SingleNode()
        {
            string RawHTML = Repo.GetTestHTML(RepoFiles.SimpleHTML);
            var Actual = HTMLParser.GetNodesByName(RawHTML, "h1");

            Assert.AreEqual(Actual.Count(), 1);
            Assert.AreEqual(Actual.First().Name, "h1");
        }
        [Test]
        public void TestGetNode_MultipleNodes()
        {
            string RawHTML = Repo.GetTestHTML(RepoFiles.SimpleHTML);
            var Actual = HTMLParser.GetNodesByName(RawHTML, "p");

            Assert.AreEqual(Actual.Count(), 2);
            Assert.AreEqual(Actual.First().Name, "p");
        }
        [Test]
        public void TestGetNodeById_MultipleNodes()
        {
            string RawHTML = Repo.GetTestHTML(RepoFiles.SimpleHTML);
            var Actual = HTMLParser.GetNodeById(RawHTML, "Hello");

            Assert.AreEqual(Actual.Count(), 1);
            Assert.AreEqual(Actual.First().Id, "Hello");
        }
    }
}
