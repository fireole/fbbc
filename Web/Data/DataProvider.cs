using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Web.Models;

namespace Web.Data
{
    public class DataProvider
    {
        public LayoutModel GetSiteData(string location)
        {
            return GetJsonData().FirstOrDefault(s => s.SiteName == location);
        }

        private List<LayoutModel> GetJsonData()
        {
            var sites = new List<LayoutModel>();

            using (var sr = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/sites.json")))
            {
                sites = JsonConvert.DeserializeObject<List<LayoutModel>>(sr.ReadToEnd());
            }

            return sites;
        }
    }
}