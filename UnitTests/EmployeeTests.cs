using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        [DataRow("John", "Doe", 30, 5000)]
        [DataRow("Homer", "Simpson", 45, 9000)]
        [DataRow("Afanasiy", "Stranikov", 18, 9000)]
        public void Employee_Constructor_ShouldInitializeProperties(
            string firstName,
            string lastName,
            int age,
            double salary
        )
        {
            // Arrange
            var employee = new Employee(firstName, lastName, age, salary);

            // Act & Assert
            Assert.AreEqual(firstName, employee.FirstName);
            Assert.AreEqual(lastName, employee.LastName);
            Assert.AreEqual(age, employee.Age);
            Assert.AreEqual(salary, employee.Salary);
        }


        [TestMethod]
        [DataRow(18)]
        [DataRow(25)]
        [DataRow(30)]
        public void Employee_Age_ShouldBeGreaterThanOrEqualTo18(int age)
        {
            // Arrange
            var employee = new Employee("John", "Doe", age, 5000);

            // Act & Assert
            Assert.IsTrue(employee.Age >= 18, "Age should be greater than or equal to 18.");
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-10)]
        [DataRow(5000)]
        public void Employee_Salary_ShouldBeGreaterThanZero(double salary)
        {
            // Arrange & Act
            if (salary <= 0)
            {
                Assert.ThrowsException<ArgumentException>(
                    () => new Employee("John", "Doe", 30, salary)
                );
            }
            else
            {
                var employee = new Employee("John", "Doe", 30, salary);

                Assert.AreEqual(salary, employee.Salary, "Salary should be greater than zero.");
            }
        }
    }
}
