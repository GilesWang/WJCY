using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WJCY.Admin.Models.Home;
using WJCY.Core.Domain;
using WJCY.Data;
using WJCY.Services;
using WJCY.Web.Framewok.Controllers;

namespace WJCY.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        #region Fields
        private IEmployeeService employeeService = null;
        #endregion

        #region ctor
        public HomeController()
        {
            employeeService = new EmployeeService(new EfRepository<Employee>());
        }
        #endregion

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact page.";

            return View();
        }
        /// <summary>
        /// 登陆页
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            ViewBag.Message = "Login";
            return View();
        }
        [HttpPost]
        public ActionResult Login(EmployeeLoginViewModel loginModel)
        {
            if (loginModel != null)
            {
                if (ModelState.IsValid)
                {
                    var employee = employeeService.GetEmployee(loginModel.EmployeeNo);
                    if (employee == null)
                    {
                        ModelState.AddModelError("", "不存在该员工");
                        return View();
                    }
                    else
                    {

                        employee = employeeService.GetEmployee(loginModel.EmployeeNo, loginModel.pwd);
                        if (employee == null)
                        {
                            ModelState.AddModelError("", "密码错误");
                            return View();
                        }
                        else
                        {
                            Session["Employee"] = employee;
                            return RedirectToAction("Index");
                        }
                    }
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

    }
}