using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using zd4_2_v2_3_Lezhen;

namespace Tests
{
    [TestClass] 
    public class UnitTestFunInputIsRight
    {
        [TestMethod] //1
        public void Test_Right()
        {
            string input = "FYUBELW";
            bool Test = FunctionalClassQuest2.InputIsRight(input);
            Assert.IsTrue(Test);
        }
        [TestMethod] //2
        public void Test_Wrong_InputIsEmpty()
        {
            string input = "";
            bool Test = FunctionalClassQuest2.InputIsRight(input);
            Assert.IsFalse(Test);
        }
        [TestMethod] //3
        public void Test_Wrong_InputIsVeryBig()
        {
            string input = "AJGSKFDJHAGFHKAGFDKJAGSFLKJHDAFLJHDALKFHDALKHFLDJGFLKDSJGFLJDAHFLJAHSDLHASDLKSAHDLJSAHDLKJSAHDl";
            bool Test = FunctionalClassQuest2.InputIsRight(input);
            Assert.IsFalse(Test);
        }
        [TestMethod] //4 
        public void Test_Wrong_InputContainNumbers()
        {
            string input = "FY6U726B2ELW";
            bool Test = FunctionalClassQuest2.InputIsRight(input);
            Assert.IsFalse(Test);
        }
        [TestMethod] //5
        public void Test_Wrong_InputContainNotUpperLetters()
        {
            string input = "dsdaFsaS";
            bool Test = FunctionalClassQuest2.InputIsRight(input);
            Assert.IsFalse(Test);
        }
    }
    [TestClass]
    public class UnitTestFunReadCoordinatesFromFile
    {
        [TestMethod] //6
        public void Test_Right()
        {
            string file = "Test_Right.txt";
            var output = FunctionalClassQuest3.ReadCoordinatesFromFile(file);
            bool test = output != null;
            Assert.IsTrue(test);
        }
        [TestMethod] //7
        public void Test_InputStringIsEmpty()
        {
            string file = "Test_InputStringIsEmpty.txt";
            var output = FunctionalClassQuest3.ReadCoordinatesFromFile(file);
            Assert.IsNull(output);
        }
        [TestMethod] //8
        public void Test_ValuesNotNumbers()
        {
            string file = "Test_ValuesNotNumbers.txt";
            var output = FunctionalClassQuest3.ReadCoordinatesFromFile(file);
            Assert.IsNull(output);
        }
        [TestMethod] //9
        public void Test_NumbersLessEight()
        {
            string file = "Test_NumbersLessEight.txt";
            var output = FunctionalClassQuest3.ReadCoordinatesFromFile(file);
            Assert.IsNull(output);
        }
        [TestMethod] //10
        public void Test_FileWasNotFound()
        {
            string file = "Test_FileWasNotFound.txt";
            var output = FunctionalClassQuest3.ReadCoordinatesFromFile(file);
            Assert.IsNull(output);
        }
    }
}
