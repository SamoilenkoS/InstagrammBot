using System;
using System.Collections.Generic;
using System.IO;
using InsagramApiByHands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ParseFollowersCount_TestClass
    {
        [DataTestMethod]
        [DataRow("1 234 test", 1234)]
        [DataRow("1 234 тест", 1234)]
        [DataRow("test 1 234 ", 1234)]
        [DataRow("тест 1 234 ", 1234)]
        [DataRow("1 234", 1234)]
        [DataRow("123",123)]
        [DataRow("12",12)]
        [DataRow("5",5)]
        [DataRow("0",0)]
        public void InputCorrect(string input, int expected)
        {
            Assert.AreEqual(expected, Parsers.ParseFollowersCount(input));
        }
        [TestMethod]
        public void EmptyInput()
        {
            Assert.AreEqual(0, Parsers.ParseFollowersCount(string.Empty));
        }
    }
    [TestClass]
    public class ReadListOfStringFromFile_TestClass
    {
        private string filepath;
        public ReadListOfStringFromFile_TestClass()
        {
            filepath = "testFile.txt";
        }
        [TestMethod]
        public void EmptyFile()
        {
            StreamWriter sw = new StreamWriter(filepath);
            sw.Close();
            Assert.AreEqual(new List<string>(),Parsers.ReadListOfStringFromFile(filepath));
        }
        [TestMethod]
        //[DataRow(new List<string>(){"1","2","3"},DisplayName ="oneTow")]
        public void N_Lines_File(List<string> fileContent)
        {

        }
    }
}
