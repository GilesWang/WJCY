using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WJCY.Web.Framewok.Controllers;

namespace WJCY.Admin.Controllers
{
    public class DictController : BaseAdminController
    {
        // GET: Dict
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DictList()
        {
            return Json(null);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string s)
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(string s)
        {
            return View();
        }


    }
}