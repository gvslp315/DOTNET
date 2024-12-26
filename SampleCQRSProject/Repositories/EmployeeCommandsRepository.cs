using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCQRSProject.Models;

namespace SampleCQRSProject.Repositories
{
    internal class EmployeeCommandsRepository :IEmployeeCommandsRepository
    {
        public void SaveEmployee(Employee employee)
        {
            // Persist the employee record in a data store
        }
    }
}
