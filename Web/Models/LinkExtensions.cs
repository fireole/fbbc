using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace Web.Models
{
    public static class LinkExtensions
    {
        public static MvcHtmlString ActionLinkBySite(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes, bool showActionLinkAsDisabled)
        {
            return htmlHelper.ActionLink(linkText, actionName, controllerName, routeValues, htmlAttributes);

        }


        public static MvcHtmlString ZenCalendar(this HtmlHelper htmlHelper, string zenName)
        {
            string calendar =$"<iframe src='https://{zenName}.zenplanner.com/zenplanner/portal/calendar.cfm?frame=true' style='width:100%; height:500px;' onLoad='window.scroll(0,0);' frameborder='0' id='idZenPlannerFrame'></iframe>";
            return new MvcHtmlString(calendar);
        }
        public static MvcHtmlString ZenCalendarJS(this HtmlHelper htmlHelper, string zenName)
        {
            string calendarJs =$"<script src='https://{zenName}.zenplanner.com/zenplanner/skin/js/resize.js' ></script>";
            return new MvcHtmlString(calendarJs);
        }
    }
}