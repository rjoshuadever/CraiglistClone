using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraiglistClone.Models
{
    public static class ProductHolder
    {
        public static List<Product> FetchProduct()
        {
            List<Product> PList = new List<Product>()
            {
                new Product(
                    Type:ProductType.Gaming,
                    ItemId:100,
                    Price: 42.00, 
                    ImgUrl: "http://images.craigslist.org/00G0G_5yikbciGveu_300x300.jpg",
                    Description: "dont really need the controller so just looking to sell it", 
                    ProductTitle: "Xbox One Controller", 
                    CreatedBy:"XboxGamer", 
                    CreatedOn: DateTime.Now.AddDays(-5), 
                    City: "San Diego", 
                    State: "California"),

                    new Product(
                    Type:ProductType.Gaming,
                    ItemId:101,
                    Price: 10.00, 
                    ImgUrl: "http://images.craigslist.org/00H0H_8wnfELOVV1b_600x450.jpg",
                    Description: "Hitman: Absolution Professional Edition (Sony Playstation 3) PS3 Brand New up for sale $10", 
                    ProductTitle: "Hitman: Absolution", 
                    CreatedBy:"Agent13", 
                    CreatedOn: DateTime.Now.AddDays(-6), 
                    City: "Chula Vista", 
                    State: "California"),

                    new Product(
                    Type:ProductType.Gaming,
                    ItemId:102,    
                    Price: 100.00, 
                    ImgUrl: "http://images.craigslist.org/00U0U_cJqmRuAydbS_600x450.jpg",
                    Description: "I'm selling a Nintendo 64 with 4 games and 1 control. Games are Off Road Challenge, Super Mario 64, Paperboy and Tetrisphere What is pictured is what you will receive Fun system to play. $100 cash and pick up in Escondido 92027 Please reply with your phone number and area code and I'll call you back soon Thank You", 
                    ProductTitle: "Nintendo 64 Video Game System", 
                    CreatedBy:"SuperMario", 
                    CreatedOn: DateTime.Now.AddDays(-7), 
                    City: "Escondido", 
                    State: "California"),

                    new Product(
                    Type:ProductType.Outdoor,
                    ItemId:105,    
                    Price: 100.00, 
                    ImgUrl: "http://images.craigslist.org/00k0k_8NOC4xsyjex_300x300.jpg",
                    Description: "Awesome ATV for sale. A little older Model, but still runs great. Can work on best offer", 
                    ProductTitle: "All Terrain Vehichle", 
                    CreatedBy:"DirtCowboy", 
                    CreatedOn: DateTime.Now.AddDays(-4), 
                    City: "Lakeside", 
                    State: "California"),

                    new Product(
                    Type:ProductType.Outdoor,
                    ItemId:106,    
                    Price: 100.00, 
                    ImgUrl: "http://images.craigslist.org/00g0g_jpknfUVEayb_600x450.jpg",
                    Description: "1999 Sand Car Unlimited 4 Seat Dune Buggy - One Owner Serviced Every Trip Purchased New - Older Adult Driven - Never Crashed, Rolled or Damaged I have over 30 years of driving experience in Glamis Dunes, This car has only ever been to the Dunes.3 point seat belts GPS Unit 8 light system 2 storage boxes Ice chest with matching cover, Always stored inside Average 3 trips per year Turbocharged, Fuel Injection, electronic ignition, 180hp VW engine 4 trips on rebuilt engine by Steve Johnson. VW 4 speed Bus Transmission close ratio beefed up by Trans Works Turbocharged by Action Turbo Mid Travel suspension Rear Paddle tires, Aluminum wheels, Razor front tires, always maintained and service super clean ready for Glamis Desert. Enclosed Trailer Available $17,900 OBO - Current Registration with Clean Clear Title Call Mike with any questions", 
                    ProductTitle: "1999 Sand Car Unlimited 4 Seat Mid Travel Dune Buggy", 
                    CreatedBy:"Muad D'ib", 
                    CreatedOn: DateTime.Now.AddDays(-4), 
                    City: "El Cajon", 
                    State: "California")
            };
            return PList;
        }

        public static string DaysAgo(DateTime DateINeed)
        {
            DateTime Now = DateTime.Now;

            TimeSpan Elapsed = Now.Subtract(DateINeed);

            double DisplayTime = Elapsed.TotalDays;

            string FinalTime = DisplayTime.ToString("0");

            return FinalTime;
        }

       
    }
}