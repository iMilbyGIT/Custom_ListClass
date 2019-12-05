using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTest_CustomListClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ObjectsToList()
        {
            //Arrange(set up)
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
            double result;
            double expectedResult = 5;

            //Act(method we are testing)
            result = numbers.Count;
            //Assert(what it is that we are determining)
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void test2()
        {
            //Arrange(set up)
            CustomList<string> numbers = new CustomList<string>();
            //Act(method we are testing)
            //Assert(what it is that we are determining)
        }
        [TestMethod]
        public void test3()
        {
            //Arrange(set up)
            CustomList<int> numbers = new CustomList<int>();
            //Act(method we are testing)
            //Assert(what it is that we are determining)
        }

        [TestMethod]
        public void test4()
        {
            //Arrange(set up)
            CustomList<int> numbers = new CustomList<int>();
            //Act(method we are testing)
            //Assert(what it is that we are determining)
        }

        [TestMethod]
        public void test5()
        {
            //Arrange(set up)
            CustomList<int> numbers = new CustomList<int>();
            //Act(method we are testing)
            //Assert(what it is that we are determining)
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