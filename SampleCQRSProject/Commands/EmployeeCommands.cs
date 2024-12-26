using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCQRSProject.Models;
using SampleCQRSProject.Repositories;

namespace SampleCQRSProject.Commands
{
    internal class EmployeeCommands : IIEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;
        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveEmployeeData(Employee employee)
        {
            _repository.SaveEmployee(employee);
        }
    }
}
