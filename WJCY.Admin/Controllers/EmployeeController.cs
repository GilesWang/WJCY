using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WJCY.Web.Framewok.Controllers;

namespace WJCY.Admin.Controllers
{
    public class EmployeeController : BaseAdminController
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
    }
}