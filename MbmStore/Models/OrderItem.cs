using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {
        // auto-implemnted properties
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; private set; }

        
        // constructors
        public OrderItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
