using CraiglistClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraiglistClone.Models
{

    // Product type enum
    public enum ProductType
    {
        Gaming,
        Outdoor,
        Furniture
    }

    public class Product
    {

        public int ItemId { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public string ProductTitle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public ProductType Type { get; set; }

        public Product(int ItemId, double Price, string ImgUrl, string Description, string ProductTitle, string CreatedBy, DateTime CreatedOn, string City, string State, ProductType Type)
        {
            this.Type = Type;
            this.ItemId = ItemId;
            this.Price = Price;
            this.ImgUrl = ImgUrl;
            this.Description = Description;
            this.ProductTitle = ProductTitle;
            this.CreatedBy = CreatedBy;
            this.CreatedOn = CreatedOn;
            this.City = City;
            this.State = State;
        }



    }
}