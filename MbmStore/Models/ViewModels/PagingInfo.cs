using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models.ViewModels
{//To support the tag helper,we will pass information
 //to the view about the number of pages available, 
//the current page,and the total number of products in the repository. 
    public class PagingInfo
    {   //auto-implemented properties
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        //read-only property
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}