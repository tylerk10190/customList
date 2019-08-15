using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests
    {
        [TestMethod]
        public void PlusOverload_AddTwoCustomListsOfIntsTogether_OneListContainingContentsOfBoth()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result;
            int expected = 2;
            int actual;

            //Act
            one.Add(1);
            two.Add(2);
            result = one + two;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_AddTwoEmptyCustomListsTogether_OneEmptyList()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            result = one + two;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_AddTwoFullCustomListsTogether_OneListContainingContentsOfBoth()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            one.Add(1);
            one.Add(2);
            one.Add(9);
            one.Add(4);
            two.Add(1);
            two.Add(2);
            two.Add(3);
            two.Add(4);
            result = one + two;
            actual = result[6];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_ChangTwoListsToStringsAddThemToOneList_OneListOfStrings()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(9);
            one.Add(4);
            two.Add(1);
            two.Add(2);
            two.Add(3);
            two.Add(4);

           string stringOne = one.ToString();
           string stringTwo = two.ToString();

            string expected = stringOne + stringTwo;
            string actual;

            //Act
            result = one + two;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
