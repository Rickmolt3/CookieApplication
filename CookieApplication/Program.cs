using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CookieApplication
{
    class Program
    {
       
        
        static void Main(string[] args)
        {

            

            Console.WriteLine("Heres your batch of cookies.");
            Console.WriteLine("----------------------------");

            cookieBatch batch = new cookieBatch();
            batch.createCookies("filling", "Choclate Chips",false);
            batch.createCookies("ccc", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);
            batch.createCookies("Choclate Chip Cookie", "Choclate Chips", false);

            foreach (cookie c in batch.batchocookies) 
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Cookie Type: " + c.cookieType);
                Console.WriteLine("Cookie Filling: " + c.cookieFilling);
                Console.WriteLine("Sugar Free: " + c.sugarFree);

            }

            Console.ReadKey();

        }
    }
   
}