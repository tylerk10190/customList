using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myCustomList;

namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        
        [TestMethod]
        public void Remove_RemoveItemFromListOfOne_ListCountZero()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            List.Add(1);
            List.Remove(1);
            actual = List.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
       [TestMethod]
       public void Remove_RemoveFirstItemInstance_OnlyOneItemInstanceLeftInList()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            List.Add(1);
            List.Add(1);
            List.Remove(1);
            actual = List[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveFirstItemInstanceInListOfOtherObjects_OnlyOneItemInstanceLeftInList()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            List.Add(1);
            List.Add(2);
            List.Add(1);
            List.Remove(1);
            actual = List[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromEmptyList_CountStillZero()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            List.Remove(0);
            actual = List.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromListOfMany_ItemsBehindRemovedItemSlideUpInArray()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            List.Add(1);
            List.Add(2);
            List.Add(1);
            List.Remove(1);
            actual = List[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveLastItemFromFullList_LastIndexEqualsDefault()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Add(4);
            List.Remove(4);
            actual = List[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveFirstItemFromFullList_ItemAtIndexOneEqualsThree()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Add(4);
            List.Remove(1);
            actual = List[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveFirstItemFromFullList_ItemAtIndexTwoEqualsFour()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            int expected = 4;
            int actual;

            //Act
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Add(4);
            List.Remove(1);
            actual = List[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
