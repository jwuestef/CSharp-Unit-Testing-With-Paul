using System;
using _02_Reference_Types_Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Employee_EmployeeID_ShouldBeCorrectInt()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.EmployeeID = 1;

            //-- Act
            int actual = employee.EmployeeID;
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Employee_NumberOfYearsExperience_ShouldBeCorrectInt()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.NumberOfYearsExperience = 15;

            //-- Act
            int actual = employee.NumberOfYearsExperience;
            int expected = 15;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Employee_EmployeeAge_ShouldBeCorrectInt()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.Age = 45;

            //-- Act
            int actual = employee.Age;
            int expected = 45;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_GetFullName_ShouldBeConcatenatedString()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.FirstName = "Kenn";
            employee.LastName = "Pascascio";

            //-- Act
            string actual = employee.GetFullName();
            string expected = "Kenn Pascascio";

            //-- Assert
            Assert.AreEqual(expected, actual);

        }






        [TestMethod]
        public void Employee_FirstName_ShouldBeCorrectString()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.FirstName = "Kenn";

            //-- Act
            string actual = employee.FirstName;
            string expected = "Kenn";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
