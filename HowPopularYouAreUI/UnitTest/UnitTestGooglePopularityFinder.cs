using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace UnitTest
{
    [TestClass]
    public class UnitTestGooglePopularityFinder
    {
        //[TestMethod]
        public void TestMethodGetPopularityFunderName()
        {
            GooglePopularityFinder.GooglePopularityFinderImpl objGooglePopularityFinderImpl  = new GooglePopularityFinder.GooglePopularityFinderImpl();
            Assert.AreEqual(objGooglePopularityFinderImpl.GetPopularityFunderName(), "GooglePopularityFinder");
        }

        [TestMethod]
        public void TestMethodGetResult()
        {
            GooglePopularityFinder.GooglePopularityFinderImpl objGooglePopularityFinderImpl = new GooglePopularityFinder.GooglePopularityFinderImpl();
            objGooglePopularityFinderImpl.SetSearchTerms(new[] { "AIMIA","sydney" });
            var result = objGooglePopularityFinderImpl.GetResult();
           
        }
    }
}
