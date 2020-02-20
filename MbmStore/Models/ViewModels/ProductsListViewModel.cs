using MbmStore.Models;
using MbmStore.Models.ViewModels;
using System.Collections.Generic;

namespace MbmStore.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}