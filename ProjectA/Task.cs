using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA;

namespace ProjectA
{
    public class Task
    {
        public string TaskName
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public TaskStatus Status
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public Employee AssignedEmployee
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int Progress
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Task(string taskName, Employee assignedEmployee)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgress(int progress)
        {
            throw new NotImplementedException();
        }

        public void ChangeStatus(TaskStatus newStatus)
        {
            throw new NotImplementedException();
        }
    }
}
