using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // auto-implemnted property
        public string Director{ set; get; }


        // constructors
        public Movie(string title, decimal price)
        {
            
        }

        public Movie(int productId, string title, decimal price, string imageUrl, string director) : base(productId, title, price, imageUrl)
        {
            this.Director = director;
        }
    }
}