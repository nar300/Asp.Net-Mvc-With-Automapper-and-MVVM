using MVC_withAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_withAutomapper.ViewModel
{
    public class ProductViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}