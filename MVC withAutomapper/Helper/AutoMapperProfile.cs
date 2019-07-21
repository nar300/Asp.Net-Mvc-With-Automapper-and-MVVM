using AutoMapper;
using MVC_withAutomapper.DTO;
using MVC_withAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_withAutomapper.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>().ForMember(
                dto => dto.CategoryName, opt =>
                {
                    opt.MapFrom(product => product.Category.Name);
                }

                ).ForMember(
                dto => dto.PricewithTax, opt =>
                {
                    opt.MapFrom(product => Convert.ToInt32(product.Price)+10);
                }
                );


            CreateMap<Category, CategoryDto>().ForMember(
                dto => dto.TotalProducts, opt =>
                {
                    opt.MapFrom(category => category.Products.Count);
                }
                
                );
        }
    }
}