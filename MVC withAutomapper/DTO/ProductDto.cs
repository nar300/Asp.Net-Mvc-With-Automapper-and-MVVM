﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_withAutomapper.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int PricewithTax { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }


    }
}