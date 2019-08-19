using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace CustomListTests
{
    [TestClass]
    public class SortMethodTests
    {
        [TestMethod]
        public void Sort_SortListOfTwoIntsToListOutOfOrder_IntAtIndexZeroIsOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> sortedList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            testList.Add(2);
            testList.Add(1);
            sortedList = sortedList.Sort(testList);
            actual = sortedList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Sort_SortListOfTwoIntsToListOutOfOrder_IntAtIndexOneIsTwo()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> sortedList = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            testList.Add(2);
            testList.Add(1);
            sortedList = sortedList.Sort(testList);
            actual = sortedList[1];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Sort_SortListOfThreeIntsToListOutOfOrder_IntAtIndexTwoIsThree()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> sortedList = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            testList.Add(2);
            testList.Add(1);
            testList.Add(3);
            sortedList = sortedList.Sort(testList);
            actual = sortedList[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Sort_SortListOfFourIntsToListOutOfOrder_IntAtIndexThreeIsFour()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> sortedList = new CustomList<int>();
            int expected = 4;
            int actual;

            //Act
            testList.Add(2);
            testList.Add(4);
            testList.Add(1);
            testList.Add(3);
            sortedList = sortedList.Sort(testList);
            actual = sortedList[3];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Sort_SortListOfTenIntsToListOutOfOrder_IntAtIndexFourIsFive()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> sortedList = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            testList.Add(2);
            testList.Add(1);
            testList.Add(3);
            testList.Add(7);
            testList.Add(5);
            testList.Add(6);
            testList.Add(4);
            testList.Add(9);
            testList.Add(8);
            testList.Add(10);
            sortedList = sortedList.Sort(testList);
            actual = sortedList[4];

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
