using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSApp.models
{
    class PartTimeEmployee:Employee
    {
        public int WorkingHour { get; set; }
        public decimal PerHourSalary { get; set; }

        //public override decimal CalculatePerMonthSalary()
        //{
        //    decimal salary = WorkingHour * PerHourSalary;
        //    return salary;
        //}
    }
}
