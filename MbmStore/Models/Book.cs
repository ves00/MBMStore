using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        // auto-implemnted properties
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }


        //constructors
        public Book()
        {

        }


        
        public Book(int productId, string title, decimal price, string imageUrl, string author, short published) : base(productId, title, price, imageUrl)
        {
            this.Author = author;
            this.Published = published;
        }
    }
}
