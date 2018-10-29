using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmersMarket.Models.Logic;
using FarmersMarket.Sql;

namespace FarmersMarket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult GetTableVendor()
        {
            var vendors = DatabaseOperations.GetVendors().AsEnumerable().Select(o => new Vendor(o)).ToList();
            return PartialView("_TableVendor", vendors);
        }
    }
}