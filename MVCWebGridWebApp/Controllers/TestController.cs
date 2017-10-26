using MVCWebGridWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebGridWebApp.Controllers
{
    public class TestController : Controller
    {
        public static bool isAdded = false;

        public ActionResult Index()
        {
            GridInfoSuhas grdDetails = new GridInfoSuhas();
            grdDetails.ListOfCustomer = new List<RowModel>();
            List<RowModel> lstCustomers = new List<RowModel>();
            RowModel rowInfo;
            for (int i = 1; i <= 15; i++)
            {
                rowInfo = new RowModel();
                rowInfo.asdasd = "asdasd" + i;
                rowInfo.asd = "asd" + i;
                rowInfo.asddd = "asddd" + i;
                lstCustomers.Add(rowInfo);
            }
            grdDetails.ListOfCustomer = lstCustomers;
            return View(grdDetails);
        }
        [HttpGet]
        public JsonResult SaveRecord(string asdasd, string asd, string asddd)
        {
            isAdded = true;
            var result = true; return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult UpdateRecord(string asdasd, string asd, string asddd)
        {
            bool result = true;
            try { }
            catch (Exception ex) { }
            return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult DeleteRecord(string id)
        {
            bool result = true;
            try { }
            catch (Exception ex) { }
            return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

    }
}
