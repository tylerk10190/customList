using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorOverloadTests
    {
        [TestMethod]
        public void MinusOverload_RemoveFirstMatchingItemInTwoListsFromFirstList_ListCountIsOne()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList;
            int expected = 1;
            int actual;

            //Act
            listOne.Add(1);
            listOne.Add(2);
            listTwo.Add(2);
            newList = listOne - listTwo;
            actual = newList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_RemoveFirstInstanceOfMatchingItemButNotSecond_ListCountIsOne()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList;
            int expected = 1;
            int actual;

            //Act
            listOne.Add(2);
            listOne.Add(2);
            listTwo.Add(2);
            newList = listOne - listTwo;
            actual = newList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_RemoveItemFromEndOfList_LastIndexIsDefault()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList;
            int expected = 0;
            int actual;

            //Act
            listOne.Add(1);
            listOne.Add(2);
            listTwo.Add(2);
            newList = listOne - listTwo;
            actual = newList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_RemoveItemFromMiddleOfList_RemovedItemIndexNowFilledByItemBehindIt()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList;
            int expected = 3;
            int actual;

            //Act
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(2);
            newList = listOne - listTwo;
            actual = newList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_SubtractTheContentsOfTwoMatchingLists_ListOneIsEmpty()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> newList;
            int expected = 0;
            int actual;

            //Act
            listOne.Add(1);
            listOne.Add(2);
            listTwo.Add(1);
            listTwo.Add(2);
            newList = listOne - listTwo;
            actual = newList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_RemoveFirstMatchingCustomObjectsFromList_ObjectAtIndexZeroIsRemainingObject()
        {
            //Arrange
            CustomList<Player> listOne = new CustomList<Player>();
            CustomList<Player> listTwo = new CustomList<Player>();
            CustomList<Player> newList;
            Player playerOne = new Player();
            Player expected = playerOne;
            Player actual;

            //Act
            listOne.Add(playerOne);
            listOne.Add(playerOne);
            listTwo.Add(playerOne);
            newList = listOne - listTwo;
            actual = newList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_RemoveMatchingCustomObjectsFromListButLeabeNonmatchingObjects_ObjectAtIndexZeroIsRemainingObject()
        {
            //Arrange
            CustomList<Player> listOne = new CustomList<Player>();
            CustomList<Player> listTwo = new CustomList<Player>();
            CustomList<Player> newList;
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Player expected = playerTwo;
            Player actual;

            //Act
            listOne.Add(playerOne);
            listOne.Add(playerTwo);
            listTwo.Add(playerOne);
            newList = listOne - listTwo;
            actual = newList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
