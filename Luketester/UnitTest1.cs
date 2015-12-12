using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Luketester
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestLuke9_1()
        {
            var inn = 1;
            var res = "A";

            Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        }
        [TestMethod]
        public void TestLuke9_2()
        {
            var inn = 2;
            var res = "B";

            Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        }
        [TestMethod]
        public void TestLuke9_3()
        {
            var inn = 26;
            var res = "Z";

            Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        }
        [TestMethod]
        public void TestLuke9_4()
        {
            var inn = 27;
            var res = "AA";

            Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        }
        [TestMethod]
        public void TestLuke9_5()
        {
            var inn = 28;
            var res = "AB";

            Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        }
        [TestMethod]
        public void TestLuke9_6()
        {
            var inn = 52;
            var res = "AZ";

            Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        }
        [TestMethod]
        public void TestLuke9_7()
        {
            var inn = 79;
            var res = "CA";

            Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        }

        //[TestMethod]
        //public void TestLuke9_9()
        //{
        //    var inn = 142453146368;
        //    var res = "CA";

        //    Assert.AreEqual(res, Luke9.Program.GetValue(inn));
        //}
    }
}
