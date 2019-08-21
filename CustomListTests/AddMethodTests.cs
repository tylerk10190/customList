using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myCustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemAddedToIndexZero()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            ListOfNumbers.Add(1);
            actual = ListOfNumbers[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddItemToListWithItem_ItemAddedToEndOfList()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            ListOfNumbers.Add(1);
            ListOfNumbers.Add(2);
            actual = ListOfNumbers[1];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncreasesByOne()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            ListOfNumbers.Add(1);
            actual = ListOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddItemToFullArray_ArraySizeIncreases()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            ListOfNumbers.Add(1);
            ListOfNumbers.Add(2);
            ListOfNumbers.Add(3);
            ListOfNumbers.Add(4);
            ListOfNumbers.Add(5);
            actual = ListOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddItemToFullArrayForSecondTime_ArraySizeIncreases()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int expected = 9;
            int actual;

            //Act
            ListOfNumbers.Add(1);
            ListOfNumbers.Add(2);
            ListOfNumbers.Add(3);
            ListOfNumbers.Add(4);
            ListOfNumbers.Add(5);
            ListOfNumbers.Add(6);
            ListOfNumbers.Add(7);
            ListOfNumbers.Add(8);
            ListOfNumbers.Add(9);
            actual = ListOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddItemToFullArray_ArrayIndexZeroRemainsTheSame()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            ListOfNumbers.Add(1);
            ListOfNumbers.Add(2);
            ListOfNumbers.Add(3);
            ListOfNumbers.Add(4);
            ListOfNumbers.Add(5);
            actual = ListOfNumbers[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddItemToFullArray_ArrayIndexEightRemainsTheSame()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int expected = 8;
            int actual;

            //Act
            ListOfNumbers.Add(1);
            ListOfNumbers.Add(2);
            ListOfNumbers.Add(3);
            ListOfNumbers.Add(4);
            ListOfNumbers.Add(5);
            ListOfNumbers.Add(6);
            ListOfNumbers.Add(7);
            ListOfNumbers.Add(8);
            ListOfNumbers.Add(9);
            actual = ListOfNumbers[7];

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
