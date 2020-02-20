using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.Models.ViewModels;
using MbmStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;//specifies that we want four products per page

        // GET: Catalogue
        public ActionResult Index(string category, int page = 1)//this means that if we call the method without parameter the call will be treted as with the defoalt 
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = Repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? 
                    Repository.Products.Count() : 
                    Repository.Products.Where(e =>
                    e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}