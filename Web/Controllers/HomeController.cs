using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            return View();
        }

        [Route("{location}")]
        public ActionResult Location(string location)
        {
            return View();
        }


        [Route("{location}/join-now")]
        public ActionResult Join(string location)
        {
            return View();
        }

        [Route("{location}/about-us")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("{location}/contact-us")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("{location}/schedule")]
        public ActionResult Schedule()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [Route("{location}/success-stories")]
        public ActionResult Success()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}