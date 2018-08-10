using System;
using _03_OOP_Defining_Classes_Exercise_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_OOP_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise_2_CustomerTests
    {


        static void Main(string[] args)
        {
        }


        [TestMethod]
        public void Customer_SendMessage_ShouldReturnString()
        {
            //-- Arrange
            Customer customer = new Customer(1, "Cody", "Boilott", 6);

            //-- Act
            string actual = customer.SendCustomerMessage();
            string expected = "This is the customer message";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Customer_SendMessage_ShouldReturnString_Again()
        {
            //-- Arrange
            Customer customer = new Customer(1, "Sally", "Smith", 4);

            //-- Act
            string actual = customer.SendCustomerMessage();
            string expected = "This is the customer message";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }



    }
}
