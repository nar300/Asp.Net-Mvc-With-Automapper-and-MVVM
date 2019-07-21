using MVC_withAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_withAutomapper.Data
{
    public class ShopDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product>Products { get; set; }
    }
}