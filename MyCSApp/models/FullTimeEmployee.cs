using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSApp.models
{
    class FullTimeEmployee:Employee, IEmployee
    {
        public decimal AnualSalary { get; set; }
        public decimal commision { get; set; }


        public void MyMethod()
        {
            Console.WriteLine("Its me !");
        }
        public Employee CreateEmployee(Employee emp)
        {
            Console.WriteLine("Employee Created");
            return emp;
        }

        public bool DeleteEmployeee(int id)
        {
            Console.WriteLine("Employee Deleted");
            return true;
        }

        public Employee GetEmployee()
        {
            return new Employee();
        }
    }
}
