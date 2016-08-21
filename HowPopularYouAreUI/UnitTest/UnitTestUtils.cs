using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace UnitTest
{
    [TestClass]
    public class UnitTestUtils
    {
        [TestMethod]
        public void TestMethodGetFiles()
        {
            var result = Utils.GetFiles(".", "*.dll");
            Assert.IsNotNull(result);

        }

        //[TestMethod]
        //public void TestMethodGetType()
        //{
        //    var result = Utils.GetType<IPopularityFinder>();
        //}
    }
}
