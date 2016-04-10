using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WJCY.Admin.Models.Common;
using WJCY.Core.Domain;
using WJCY.Web.Framewok.Controllers;

namespace WJCY.Admin.Controllers
{
    public class CommonController : BaseAdminController
    {
        // GET: Common
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            var employee = (Employee)Session["Employee"];
            List<MenuViewModel> menu = null;
            if (employee == null)
            {
                menu = new List<MenuViewModel>();
            }
            else
            {
                menu = GetMenu(employee.EmployeeNo);
            }

            return PartialView(menu);
        }

        private List<MenuViewModel> GetMenu(int userId)
        {
            var menuList = new List<MenuViewModel>();
            if (userId == 123)
            {
                menuList.Add(new MenuViewModel()
                {
                    MenuText = "日志系统",
                    MenuAction = "SystemList",
                    MenuController = "Log",
                    ChildMenuList = new List<MenuViewModel>() {
                    new MenuViewModel() {MenuText = "日志系统",
                    MenuAction = "SystemList",
                    MenuController = "Log",

                    ChildMenuList=new List<MenuViewModel>() {
                    new MenuViewModel() {MenuText = "日志系统",
                    MenuAction = "SystemList",
                    MenuController = "Log"} } },
                    new MenuViewModel() { MenuText = "日志系统",
                    MenuAction = "LogList",
                    MenuController = "Log"}

                }
                });
            }
            else if (userId == 1234)
            {

                menuList.Add(new MenuViewModel()
                {
                    MenuText = "字典系统",
                    MenuAction = "DictKeyList",
                    MenuController = "Dict",
                    ChildMenuList = new List<MenuViewModel>() {
                    new MenuViewModel() {MenuText = "字典Key",
                    MenuAction = "DictKeyList",
                    MenuController = "Dict"
                    },
                    new MenuViewModel() { MenuText = "字典值",
                    MenuAction = "DictValueList",
                    MenuController = "Dict"}

                }
                });
            }
            return menuList;

        }
    }
}