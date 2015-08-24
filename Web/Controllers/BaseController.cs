using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        public LayoutModel Model;


        public BaseController()
        {
            var req = System.Web.HttpContext.Current.Request;
            string location = String.Empty;
            if(req.Url.Segments.Length > 1)
                location = req.Url.Segments[1].Replace("/", "");

            var model = new DataProvider().GetSiteDate(location);

            ViewBag.LayoutModel = model;
        }
    }
}