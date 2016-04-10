using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WJCY.Web.Framewok.Controllers;

namespace WJCY.Admin.Controllers
{
    public class LogController : BaseAdminController
    {
        // GET: Log
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult SystemList()
        {
            return View();
        }

        public ActionResult LogList()
        {
            return View();
        }
    }
}