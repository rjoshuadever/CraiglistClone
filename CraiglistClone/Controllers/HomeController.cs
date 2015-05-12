using CraiglistClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraiglistClone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductVm ViewProducts = new ProductVm();

            var ProductResults = ProductHolder.FetchProduct();
            var ProductSorted = ProductResults.OrderByDescending(p => p.CreatedOn).ToList();

            ViewProducts.MyProduct = ProductSorted;
           
            return View(ViewProducts);
        }

        public ActionResult ViewDetails(int Id)
        {
            ProductVm ViewDetails = new ProductVm();
            var SingleItem = ProductHolder.FetchProduct().Where(p => p.ItemId == Id).ToList();
            ViewDetails.MyProduct = SingleItem;
            return View(ViewDetails);
        }

       
        public ActionResult Gaming()
        {
            ViewBag.Message = "Stuff For Gamers.";
            ProductVm GamingVm = new ProductVm();
            var GamingList = ProductHolder.FetchProduct().Where(p => p.Type == ProductType.Gaming).ToList();
            GamingVm.MyProduct = GamingList;
          
            return View(GamingVm);
        }

        public ActionResult Outdoor()
        {
            
            ProductVm OutdoorVm = new ProductVm();
            var OutDoorList = ProductHolder.FetchProduct().Where(p => p.Type == ProductType.Outdoor).ToList();
            OutdoorVm.MyProduct = OutDoorList;

            return View(OutdoorVm);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}