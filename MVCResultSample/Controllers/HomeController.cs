using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCResultSample.Controllers
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

        public ActionResult Information() 
        {
            var result = new ContentResult();
            result.Content = "I display additional information here!";
            return result;
        }

        public ActionResult Download() 
        {
            string path = Server.MapPath("~/Files/outline.pdf");
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "application/octect-stream", "sample.pdf");
        }
        
    }
}