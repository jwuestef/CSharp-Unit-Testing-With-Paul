using System;
using _03_OOP_Defining_Classes_Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_OOP_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise_1_CarTests
    {
        [TestMethod]
        public void Car_CarMake_ShouldBeSetToString()
        {
            //-- Arrange
            Car car = new Car("Ferrari", "Testarosa", 2000);

            //-- Act
            string expected = "Ferrari";
            string actual = car.Make;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Car_CarModel_ShouldBeSetToString()
        {
            //-- Arrange
            Car car = new Car("Ferrari", "Testarosa", 2000);

            //-- Act
            string expected = "Testarosa";
            string actual = car.Model;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Car_CarYear_YearShouldBeInt()
        {
            //-- Arrange
            Car car = new Car("Lamborghini", "Countach", 1994);




            Car meCar = new Car("Honda", "CRV", 2005);
            Car camCar = new Car("Kia", "Lancer", 2012);







            //-- Act
            int expected = 1994;
            int actual = car.Year;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }



    }
}
