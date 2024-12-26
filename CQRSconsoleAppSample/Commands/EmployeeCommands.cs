using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSconsoleAppSample.Models;
using CQRSconsoleAppSample.Repositories;

namespace CQRSconsoleAppSample.Commands
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
