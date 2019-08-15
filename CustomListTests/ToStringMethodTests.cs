using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToString_AddIntToListAndChangeToString_IntIsString()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "1";
            string actual;


            //Act
            list.Add(1);
            actual = list.ToString();
            


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ToString_AddMultipleIntsToListAndChangeToString_EntireListIsString()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "123";
            string actual;


            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            actual = list.ToString();
            


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToString_ChangeEmptyListTypeFromIntToString_ListTypeIsString()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "";
            string actual;


            //Act
            list.ToString();
            actual = list.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
