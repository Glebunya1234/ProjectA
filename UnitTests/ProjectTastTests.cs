using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class ProjectTaskTest
    {
        [DataTestMethod]
        [DataRow("Task 1")]
        [DataRow("Task 2")]
        [DataRow("Task 3")]
        public void Task_Constructor_ShouldInitializeTaskWithGivenValues(string expectedName)
        {
            // Arrange
            var employee = new Employee("John", "Doe", 30, 5000);

            // Act
            var task = new ProjectTask(expectedName, employee);

            // Assert
            Assert.AreEqual(expectedName, task.TaskName);
            Assert.AreEqual(employee, task.AssignedEmployee);
            Assert.AreEqual(StatusProjectTask.Pending, task.Status);
        }

        [TestMethod]
        [DataRow(StatusProjectTask.Completed)]
        [DataRow(StatusProjectTask.Missed)]
        [DataRow(StatusProjectTask.Pending)]
        public void Task_ChangeStatus_ShouldUpdateStatus(StatusProjectTask newStatus)
        {
            // Arrange
            var employee = new Employee("John", "Doe", 30, 5000);
            var task = new ProjectTask("Test Task", employee);

            // Act
            task.ChangeStatus(newStatus);

            // Assert
            Assert.AreEqual(newStatus, task.Status);
        }



        [DataTestMethod]
        [DataRow(StatusProjectTask.Pending, StatusProjectTask.Completed)]
        [DataRow(StatusProjectTask.Missed, StatusProjectTask.Pending)]
        [DataRow(StatusProjectTask.Completed, StatusProjectTask.Pending)]

        public void Task_ChangeStatus_ShouldUpdateStatusCorrectly(
           StatusProjectTask defaultStatus,
           StatusProjectTask expectedStatus
        )
        {
            // Arrange
            var employee = new Employee("John", "Doe", 30, 5000);
            var task = new ProjectTask("Test Task", employee) { Status = defaultStatus };

            // Act
            task.ChangeStatus(expectedStatus);

            // Assert
            Assert.AreEqual(expectedStatus, task.Status);
        }
    }
}
