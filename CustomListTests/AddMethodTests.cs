using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

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

        public void Add_AddExtraIndiciesToArray_ExtraIndicesAreAddedToEndOfArray()
        {
            CustomList<T> 
        }
    }
}
