using System.Web.Mvc;
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
            var location = string.Empty;
            if (req.Url.Segments.Length > 1)
                location = req.Url.Segments[1].Replace("/", "");

            var model = new DataProvider().GetSiteData(location);
            ViewBag.LayoutModel = model;
        }
    }
}