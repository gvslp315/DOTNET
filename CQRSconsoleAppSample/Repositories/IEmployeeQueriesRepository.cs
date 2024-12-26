using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSconsoleAppSample.Models;

namespace CQRSconsoleAppSample.Repositories
{
    internal interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);

    }
}
