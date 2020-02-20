using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        // auto-implemnted properties
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; private set; }
        public Customer Customer { get; set; }
        //field
        private List<OrderItem> orderItems = new List<OrderItem>();


        // properties
        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }


        // constructors
        public Invoice(decimal totalPrice)
        {

        }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
        }


        // methods
        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}
