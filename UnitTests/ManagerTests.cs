using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        [DataRow("Alice", "Smith", 35)]
        public void Manager_Constructor_ShouldInitializeProperties(
            string firstName,
            string lastName,
            int age
        )
        {
            // Arrange
            var manager = new Manager(firstName, lastName, age);

            // Act & Assert
            Assert.AreEqual(firstName, manager.FirstName);
            Assert.AreEqual(lastName, manager.LastName);
            Assert.AreEqual(age, manager.Age);
            Assert.IsNotNull(manager.Team);
            Assert.IsNotNull(manager.Projects);
        }

        [TestMethod]
        [DataRow("John", "Doe", 30, 5000)]
        [DataRow("Jane", "Doe", 28, 4000)]
        public void Manager_AddEmployeeToTeam_ShouldAddEmployeeToList(
            string firstName,
            string lastName,
            int age,
            double salary
        )
        {
            // Arrange
            var manager = new Manager("Alice", "Smith", 35);
            var employee = new Employee(firstName, lastName, age, salary);

            // Act
            manager.Team.Add(employee);

            // Assert
            Assert.AreEqual(1, manager.Team.Count);
            Assert.AreEqual(employee, manager.Team[0]);
        }


        [TestMethod]
        public void Manager_AssignTask_ShouldThrowNotImplementedException()
        {
            // Arrange
            var manager = new Manager("Alice", "Smith", 35);
            var employee = new Employee("John", "Doe", 30, 5000);
            var task = new ProjectTask("Task 1", employee);

            // Act & Assert
            Assert.ThrowsException<NotImplementedException>(
                () => manager.AssignTask(employee, task)
            );
        }


        [DataTestMethod]
        [DataRow(1000, 6000)]
        [DataRow(-1000, 4000)]
        [DataRow(-6000, 0)]
        public void Manager_RaiseSalary_ShouldCorrectlyModifySalary(double salaryChange, double expectedSalary)
        {
            var manager = new Manager("Alice", "Smith", 35);
            var employee = new Employee("John", "Doe", 30, 5000);

            // Act
            if (salaryChange < 0 && employee.Salary + salaryChange < 0)
            {
                // Assert
                Assert.ThrowsException<ArgumentException>(
                    () => manager.RaiseSalary(employee, salaryChange)
                );
            }
            else
            {
                // Act: Apply salary change
                manager.RaiseSalary(employee, salaryChange);

                // Assert: Check the new salary
                Assert.AreEqual(expectedSalary, employee.Salary);
            }
        }

        [TestMethod]
        public void Manager_GetRole_ShouldReturnManagerRole()
        {
            // Arrange
            var manager = new Manager("Alice", "Smith", 35);

            // Act
            var role = manager.GetRole();

            // Assert
            Assert.AreEqual(RoleType.MANAGER, role);
        }
    }
}
