using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDemo.Models;
namespace EFDemo.Controllers
{
    public class DepartmentsController : Controller
    {
        MVC_DBEntities  entities = new MVC_DBEntities();
        // GET: Departments
        public ActionResult Index()
        {

            return View(entities.Departments.ToList());
        }
    }
}