using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCQRSProject.DTOs;

namespace CQRSconsoleAppSample.Queries
{
    internal interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);

    }
}
