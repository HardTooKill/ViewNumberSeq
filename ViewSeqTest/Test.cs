using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ViewSeqTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ViewSequenceNumber()
        {
            //build model
            ViewNumberSeq.Models.Number num = new ViewNumberSeq.Models.Number();
            num.number = 20;
            num.buildSeq();

            //build expected result
            string expectedallnumber = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,";
            string expectedOddnumber = "1,3,5,7,9,11,13,15,17,19,";
            string expectedEvennumber = "2,4,6,8,10,12,14,16,18,20,";
            string expectedSpecialnumber = "1,2,C,4,E,C,7,8,C,E,11,C,13,14,C,16,17,C,19,E,";
            string expectedFibonumber = "1,2,3,5,8,13,";

            Assert.IsTrue(expectedallnumber.Equals(num.AllNumberstring));
            Assert.IsTrue(expectedOddnumber.Equals(num.OddNumberstring));
            Assert.IsTrue(expectedEvennumber.Equals(num.EvenNumberstring));
            Assert.IsTrue(expectedSpecialnumber.Equals(num.SpecialNumberstring));
            Assert.IsTrue(expectedFibonumber.Equals(num.FibonacciNumberstring));
        }
    }
}
