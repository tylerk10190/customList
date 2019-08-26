using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myCustomList;

namespace CustomListTests
{
    [TestClass]
    public class IndexExceptionTests
    {
        [TestMethod]
        public void IndexException_AttemptToAccessNegativeIndex_IndexOutOfRangeExceptionThrown()
        {
            CustomList<int> testList = new CustomList<int>();
            Exception expected = new IndexOutOfRangeException();
            int actual;

            //Act
            testList.Add(1);
            
            actual = testList[-1];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IndexException_AttemptToAccessIndexGreaterThanCount_IndexOutOfRangeExceptionThrown()
        {
            CustomList<int> testList = new CustomList<int>();
            Exception expected = new IndexOutOfRangeException();
            int actual;

            //Act
            testList.Add(1);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
