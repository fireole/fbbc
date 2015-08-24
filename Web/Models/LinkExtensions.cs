using System.Collections.Generic;
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
    }
}