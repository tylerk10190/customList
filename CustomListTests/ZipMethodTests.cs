using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace CustomListTests
{
    [TestClass]
    public class ZipMethodTests
    {
        [TestMethod]
        public void Zip_ZipTwoListsOfOneTogether_ZippedListOrderedOneThenTwo()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> ZippedList;
            int expected = 2;
            int actual;

            //Act
            listOne.Add(1);
            listTwo.Add(2);
            ZippedList = CustomList<int>.Zip(listOne, listTwo);
            actual = ZippedList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipListOfEvenAndListOfOddTogether_ZippedListIndexOneIsTwo()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> ZippedList;
            int expected = 2;
            int actual;

            //Act
            listOne.Add(1);
            listOne.Add(3);
            listTwo.Add(2);
            ZippedList = CustomList<int>.Zip(listOne, listTwo);
            actual = ZippedList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipListOneAndListTwoWhenListOneHasHigherCount_ZippedListIndexThreeEqualsFive()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> ZippedList;
            int expected = 5;
            int actual;

            //Act
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listTwo.Add(2);
            ZippedList = CustomList<int>.Zip(listOne, listTwo);
            actual = ZippedList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoListsOfOneTogether_ZippedListCountIsTwo()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> ZippedList;
            int expected = 2;
            int actual;

            //Act
            listOne.Add(1);
            listTwo.Add(2);
            ZippedList = CustomList<int>.Zip(listOne, listTwo);
            actual = ZippedList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoEmptyLists_ZippedListCountZero()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> ZippedList;
            int expected = 0;
            int actual;

            //Act
            ZippedList = CustomList<int>.Zip(listOne, listTwo);
            actual = ZippedList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoFullListsOfInts_ZippedListHasCountOfEight()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> ZippedList;
            int expected = 8;
            int actual;

            //Act
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listOne.Add(7);
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);
            listTwo.Add(8);
            ZippedList = CustomList<int>.Zip(listOne, listTwo);
            actual = ZippedList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
