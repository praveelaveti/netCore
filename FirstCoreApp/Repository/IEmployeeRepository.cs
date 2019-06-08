using FirstCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Repository
{
   public  interface IEmployeeRepository
    {
        Employee getEmplyee(int id);
        IEnumerable<Employee> getEmpList();
        Employee createEmployee(Employee employee);
    }
}
