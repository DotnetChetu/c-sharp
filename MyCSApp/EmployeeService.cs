using MyCSApp.models;
using System.Collections.Generic;
using System.Linq;

namespace MyCSApp
{

    class EmployeeService
    {
        private List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>()
            {
               
                 
                    new Employee(){EmpId=103,Fname="ram",Lname="singh",Gender="Male",Address="delhi"},
                      new Employee(){EmpId=104,Fname="aditya",Lname="jay",Gender="Male",Address="noida"},
                        new Employee(){EmpId=105,Fname="hema",Lname="dinkar",Gender="Female",Address="Delhi"},
            };
  var emp1 = new Employee() { EmpId = 101, Fname = "ajay", Lname = "malhotra", Gender = "Male", Address = "noida" };
 var emp2 = new Employee() { EmpId = 102, Fname = "vijay", Lname = "malhotra", Gender = "Male", Address = "noida" };
            employees.Add(emp1);
            employees.Add(emp2);


        }

        public List<Employee> GetEmployees()
        {
            return employees.ToList();
        }
        public Employee AddEmployee(Employee emp)
        {
            employees.Add(emp);
            return emp;
        }
        public Employee GetEmployeeById(int id)
        {
            if (employees.Any(e => e.EmpId == id))
            {
                var emp = employees.SingleOrDefault(e => e.EmpId == id);
                return emp;
            }
            else
            {
                return null;
            }
        }
        public bool DeleteEmployee(int id)
        {
            if (employees.Any(e => e.EmpId == id))
            {
                var emp = employees.SingleOrDefault(e => e.EmpId == id);
                employees.Remove(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
