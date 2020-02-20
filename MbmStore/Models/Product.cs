using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        // auto-implemnted properties
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }



        // constructors
        public Product()
        {

        }

        public Product(int productId, string title, decimal price, string imageUrl)
        {
            this.ProductId = productId;
            this.Title = title;
            this.Price = price;
            this.ImageUrl = imageUrl;
        }
    }
}
