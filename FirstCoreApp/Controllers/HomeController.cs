using FirstCoreApp.Models;
using FirstCoreApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _iemployeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _iemployeeRepository = employeeRepository;
        }

       
        public ViewResult Index() {
            var empList = _iemployeeRepository.getEmpList();
            return View(empList) ;
        }
      
        public ViewResult Details(int? id)
        {
            Employee employee = _iemployeeRepository.getEmplyee(id??1);
            return View(employee);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var emp = _iemployeeRepository.createEmployee(employee);
                return RedirectToAction("Details", new { id = emp.ID });
            }
            return View();
        }
    }
}
