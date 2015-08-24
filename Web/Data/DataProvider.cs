using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data
{
    public class DataProvider
    {
        public LayoutModel GetSiteDate(string location)
        {

            var data = new LayoutModel();

            if (location == "chandlerfitnessbootcamp")
            {
                data.FirstName = "Antonio";
                data.LastName = "Olander";
                data.SiteName = "chandlerfitnessbootcamp";
                data.TitleName = "Chandler Fit Body Boot Camp";
                data.SiteAddress = "950 E Pecos Rd, Chandler AZ 85225";
                data.Phone = "480-725-9073";
                data.SocialFacebook = "fitbodychandler";
                data.SocialGoogle = "";
                data.SocialTwitter = "fitbodychandler";
            } else if (location == "ontariofitnessbootcamp")
            {
                data.FirstName = "Bedros";
                data.LastName = "The Beast";
                data.SiteName = "ontariofitnessbootcamp";
                data.TitleName = "Ontario Fit Body Boot Camp";
                data.SiteAddress = "2409 S. Vineyard Ave Unit J Ontario, CA 91761";
                data.Phone = "(909) 436-7402";
                data.SocialFacebook = "fitbodychandler";
                data.SocialGoogle = "";
                data.SocialTwitter = "ontariofbbc";
            }




            return data;

        }
    }
}
