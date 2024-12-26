using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCQRSProject.DTOs;
using SampleCQRSProject.Repositories;


namespace CQRSconsoleAppSample.Queries
{
    internal class EmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _repository;
        private EmployeeQueriesRepository employeeQueriesRepository;

        public EmployeeQueries(IEmployeeQueriesRepository repository)
        {
            _repository = repository;
        }

        public EmployeeQueries(EmployeeQueriesRepository employeeQueriesRepository)
        {
            this.employeeQueriesRepository = employeeQueriesRepository;
        }

        public EmployeeDTO FindByID(int employeeID)
        {
            var emp = _repository.GetByID(employeeID);
            return new EmployeeDTO
            {
                Id = emp.Id,
                FullName = emp.FirstName + " " + emp.LastName,
                Address = emp.Street + " " + emp.City + " " + emp.PostalCode,
                Age = Convert.ToInt32(Math.Abs(((DateTime.Now - emp.DateOfBirth).TotalDays) / 365)) - 1
            };
        }
    }
}
