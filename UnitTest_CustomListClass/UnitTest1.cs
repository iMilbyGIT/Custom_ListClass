using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTest_CustomListClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_IntObjectsToList()
        {
            //Arrange(set up)
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
            int result;
            int expectedResult = 10;

            //Act(method we are testing)
            result = numbers[4];

            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Add_StringObjectsToList()
        {
            //Arrange(set up)
            CustomList<string> numbers = new CustomList<string>();
            numbers.Add("2");
            numbers.Add("4");
            numbers.Add("6");
            numbers.Add("8");
            numbers.Add("10");
            int result;
            int expectedResult = 5;

            //Act(method we are testing)
            result = numbers.Count;

            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Add_VerifyStringIndexValue()
        {
            //Arrange(set up)
            CustomList<string> firstname = new CustomList<string>();
            string name1 = "Larry";
            string name2 = "Gary";
            string name3 = "Terry";
            string name4 = "Kerry";
            string name5 = "Jerry";
            firstname.Add(name1);
            firstname.Add(name2);
            firstname.Add(name3);
            firstname.Add(name4);
            firstname.Add(name5);
            string actual;
            string expectedResult = "Gary";

            //Act(method we are testing)
            actual = firstname[1];

            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Remove_9NamesListTo8NamesList()
        {
            //Arrange(set up)
            CustomList<string> firstnames = new CustomList<string>() { "Larry", "Gary", "Terry", "Kerry", "Jerry", "Mary", "Harry", "Dairy", "Perry" };
            firstnames.Remove("Larry");
            string actual;
            string expectedResult = "Gary";

            //Act(method we are testing)
            actual = firstnames[0];

            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Remove_FirstIndexVerifyNewIndex()
        {
            //Arrange(set up)
            CustomList<int> singledigits = new CustomList<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9};
            singledigits.RemoveAt(4);
            int actual;
            int expectedResult = 7;

            //Act(method we are testing)
            actual = singledigits.Count;

            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void RemoveAt_NameIndexLocation()
        {
            //Arrange(set up)
            CustomList<int> reversesingledigits = new CustomList<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            reversesingledigits.RemoveAt(0);
            int actual;
            int expectedResult = 8;

            //Act(method we are testing)
            actual = reversesingledigits[0];

            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
