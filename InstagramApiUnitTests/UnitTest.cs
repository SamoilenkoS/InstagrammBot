using System;
using InsagramApiByHands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstagramApiUnitTests
{
    [TestClass]
    public class ParseFollowersCount_TestClass
    {
        [DataTestMethod]
        [DataRow("1 234",1234)]
        public void InputCorrect(string input,int expected)
        {
            Assert.AreEqual(expected, Parsers.ParseFollowersCount(input));
        }
    }
}
