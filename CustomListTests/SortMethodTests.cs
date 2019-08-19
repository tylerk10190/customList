using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace CustomListTests
{
    [TestClass]
    public class SortMethodTests
    {
        [TestMethod]
        public void Sort_SortListOfTwoIntsToListOutOfOrder_IntAtIndexOneIsTwo()
        {
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> sortedList = new CustomList<int>();
            int expected = 2;
            int actual;

            testList.Add(2);
            testList.Add(1);
            sortedList = sortedList.Sort(testList);
            actual = sortedList[1];

            Assert.AreEqual(expected, actual);

        }
    }
}
