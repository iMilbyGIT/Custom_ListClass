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
            CustomList<string> numbers = new CustomList<string>();
            string name1 = "Larry";
            string name2 = "Gary";
            string name3 = "Terry";
            string name4 = "Kerry";
            string name5 = "Jerry";     
                       
            numbers.Add(name1);
            numbers.Add(name2);
            numbers.Add(name3);
            numbers.Add(name4);
            numbers.Add(name5);
            string actual;
            string expectedResult = "Gary";

            //Act(method we are testing)
            actual = numbers[1];
            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
//public void Remove_ObjectsFromList()
//{
//    //Arrange(set up)
//    CustomList<int> numbers2 = new CustomList<int>(); //{ 2, 4, 6, 8, 10 };
//    numbers2.Remove(2);
//    numbers2.Remove(4);
//    numbers2.Remove(6);
//    numbers2.Remove(8);
//    numbers2.Remove(10);
//    double result;
//    double expectedResult = 0;

//    //Act(method we are testing)
//    result = numbers2.Count;

//    //Assert(what it is that we are determining)
//    Assert.AreEqual(expectedResult, result);
//}