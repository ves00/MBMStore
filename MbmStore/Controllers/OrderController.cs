﻿using Microsoft.AspNetCore.Mvc;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class OrderController : Controller
    {
        private Cart cart;

        public OrderController(Cart cartService) { cart = cartService; }


        public ViewResult Checkout() { return View(new Order()); }

        /*The Checkoutaction method is decorated with the HttpPost attribute,
        which means that it will beinvoked for a POST request—in this case, when the user submits the form.*/ 
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                // order processing logic
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(order);
            }
        }
    }
}
