using MVC_withAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MVC_withAutomapper.DTO
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalProducts { get; set; }
        public ICollection<Product> Products { get; set; } = new Collection<Product>();
    }
}