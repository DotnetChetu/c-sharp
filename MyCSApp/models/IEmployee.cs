using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSApp.models
{
    interface IEmployee
    {
        Employee GetEmployee();
        Employee CreateEmployee(Employee emp);
        bool DeleteEmployeee(int id);

    }
}
