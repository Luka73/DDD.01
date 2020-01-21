using AutoMapper;
using Project.Application.Models.Products;
using Project.Application.Models.Stock;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Application.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Stock, ReadStockModel>()
                .AfterMap((src, dest) => dest.ProductCount = src.Products.Count());
            CreateMap<Product, ReadProductModel>();

        }
    }
}
