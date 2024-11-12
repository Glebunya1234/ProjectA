using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Employee : IPerson
    {
        public double Salary
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public StatusProjectTask TaskStatus
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public List<ProjectTask> AssignedTasks
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string FirstName
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string LastName
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int Age
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Employee(string firstName, string lastName, int age, double salary)
        {
            throw new NotImplementedException();
        }

        public void ChangeTaskStatus(ProjectTask task, StatusProjectTask status)
        {
            throw new NotImplementedException();
        }

        public RoleType GetRole()
        {
            throw new NotImplementedException();
        }
    }
}
