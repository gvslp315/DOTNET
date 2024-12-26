using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSconsoleAppSample.Models;

namespace CQRSconsoleAppSample.Commands
{
    internal interface IIEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);

    }
}
