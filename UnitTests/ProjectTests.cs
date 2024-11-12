using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        [DataRow("Project A", "2025-12-31")]
        [DataRow("Project B", "2023-06-30")]
        [DataRow("Project C", "2024-01-01")]
        public void Project_Creation_ShouldInitializeCorrectly(string projectName, string deadline)
        {
            // Arrange
            DateTime projectDeadline = DateTime.Parse(deadline);

            // Act
            var project = new Project(projectName, projectDeadline);

            // Assert
            Assert.AreEqual(projectName, project.ProjectName);
            Assert.AreEqual(projectDeadline, project.Deadline);
        }

        [TestMethod]
        [DataRow("Task 1", "Completed")]
        [DataRow("Task 2", "Pending")]
        [DataRow("Task 3", "Missed")]
        public void Project_AddTask_ShouldAddTaskToProject(string taskName, string status)
        {
            // Arrange
            var project = new Project("Test Project", DateTime.Now);
            var employee = new Employee("John", "Doe", 30, 5000);
            var task = new ProjectTask(taskName, employee)
            {
                Status = Enum.Parse<StatusProjectTask>(status)
            };

            // Act
            project.Tasks.Add(task);

            // Assert
            Assert.AreEqual(1, project.Tasks.Count);
            Assert.AreEqual(taskName, project.Tasks[0].TaskName);
            Assert.AreEqual(status, project.Tasks[0].Status.ToString());
        }

        [TestMethod]

        public void Project_UpdateProgress_ShouldUpdateProgressBasedOnTasks()
        {
            // Arrange
            var project = new Project("Test Project", DateTime.Now);


            var employee1 = new Employee("John", "Doe", 30, 5000);
            var employee2 = new Employee("Jane", "Smith", 28, 4500);

            var task1 = new ProjectTask("Task 1", employee1) { Status = StatusProjectTask.Pending };
            var task2 = new ProjectTask("Task 2", employee2) { Status = StatusProjectTask.Pending };

            project.Tasks.Add(task1);
            project.Tasks.Add(task2);

            employee1.ChangeTaskStatus(employee1.AssignedTasks[0], StatusProjectTask.Completed);

            // Act          
            project.UpdateProgress();

            // Assert
            Assert.AreEqual(50, project.Status);
        }
    }
}
