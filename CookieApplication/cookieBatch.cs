using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CookieApplication
{
    class cookieBatch
    {


        private List<cookie> batchOfCookies = new List<cookie>();

        public List<cookie> batchocookies
        {
            get { return batchOfCookies; }

        }
        public cookieBatch()
        { }

        public void createCookies(string cookieType, string cookieFilling, bool sugarFree)
        {
            cookie tastyCookie = new cookie();
            tastyCookie.cookieType = cookieType;
            tastyCookie.cookieFilling = cookieFilling;
            tastyCookie.sugarFree = sugarFree;

            //new cookie() { cookieType = "Choclate Chip Cookie", cookieFilling = "Choclate Chips", sugarFree = false };
            //new cookie() { cookieType = "Snickerdoodle Cookie", cookieFilling = "Sugar", sugarFree = false };
            //new cookie() { cookieType = "Peanut Butter Cookie", cookieFilling = "Peanut Butter", sugarFree = false };
            //new cookie() { cookieType = "Apple Cinnamon Cookie", cookieFilling = "Cinnamon", sugarFree = false };
            //new cookie() { cookieType = "Almond Cookie Cookie", cookieFilling = "Almond", sugarFree = false };
            //new cookie() { cookieType = "Macademia Nut Cookie", cookieFilling = "Choclate Chips", sugarFree = false };
            //new cookie() { cookieType = "Choclate Crunch Cookie", cookieFilling = "Choclate Chips", sugarFree = false };
            //new cookie() { cookieType = "Gluten Free Choclate Cookie", cookieFilling = "Gluten Free Choclate Chips", sugarFree = true };
            //new cookie() { cookieType = "Mint Cookie", cookieFilling = "Mint", sugarFree = false };
            //new cookie() { cookieType = "Choclate Chip Cookie", cookieFilling = "Choclate Chips", sugarFree = false };
            //new cookie() { cookieType = "Choclate Chip Cookie", cookieFilling = "Choclate Chips", sugarFree = false };
            //new cookie() { cookieType = "Choclate Chip Cookie", cookieFilling = "Choclate Chips", sugarFree = false };
            batchOfCookies.Add(tastyCookie);
        }


    }
}
