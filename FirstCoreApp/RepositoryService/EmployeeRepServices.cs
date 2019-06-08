using FirstCoreApp.Models;
using FirstCoreApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.RepositoryService
{
    public class EmployeeRepServices : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public EmployeeRepServices() {
            _employeeList = new List<Employee>() {
            new Employee{ID=1,Name="Praveen",Email="praveen@gmail" ,Departmnt=Dept.CSE},
            new Employee { ID = 2, Name = "Laddu", Email = "laddu@gmail", Departmnt = Dept.ECE },
            new Employee { ID = 3, Name = "Chinni", Email = "chinni@gmail", Departmnt = Dept.CSE },
            new Employee { ID = 4, Name = "Jonam", Email = "Jonam@gmail", Departmnt = Dept.ECE }
            };
        }

        public Employee createEmployee(Employee employee)
        {
            employee.ID = _employeeList.Max(a => a.ID) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> getEmpList()
        {
            return _employeeList;
        }

        public Employee getEmplyee(int id) {
            return _employeeList.Where(a => a.ID == id).FirstOrDefault();
        }
    }
}
