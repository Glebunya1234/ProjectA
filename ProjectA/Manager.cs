using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Manager : IPerson
    {
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
        public List<Employee> Team
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public List<Project> Projects
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Manager(string firstName, string lastName, int age, double salary)
        {
            throw new NotImplementedException();
        }

        public RoleType GetRole()
        {
            throw new NotImplementedException();
        }

        public void AssignTask(Employee employee, Task task)
        {
            throw new NotImplementedException();
        }

        public void RaiseSalary(Employee employee, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
