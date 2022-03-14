using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDemo.Models;
namespace EFDemo.Controllers
{
    public class EmployeesController : Controller
    {
        MVC_DBEntities entities=new MVC_DBEntities();
        // GET: Employees
        //public ActionResult Index()
        //{
            
        //    return View(entities.Employees.ToList());
        //}
        public ActionResult Index(int departmentid)
        {
            var employees = entities.Employees.Where(emp => emp.departmentid == departmentid).ToList();
            return View(employees);
        }
        public ActionResult EmplList()
        {

            return View(entities.Employees.ToList());
        }
        public ActionResult Details(int id)
        {
           
            Employee employee = entities.Employees.FirstOrDefault(e => e.Id == id);
            return View(employee);
        }
    }
}