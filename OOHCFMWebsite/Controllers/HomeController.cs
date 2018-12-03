using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OOHCFMWebsite.Data;
using OOHCFMWebsite.Data.Interfaces;

namespace OOHCFMWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetData()
        {
            ICFMDataRetriever ret = new CFMDataRetriever();
            ret.ExtractJsonFilesFromZip("");
            return View("Index");
        }
    }
}