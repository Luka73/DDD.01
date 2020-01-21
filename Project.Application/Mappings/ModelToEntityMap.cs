using AutoMapper;
using Project.Application.Models.Products;
using Project.Application.Models.Stock;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Mappings
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<CreateStockModel, Stock>()
                .AfterMap((src, dest) => dest.CreatedAt = DateTime.Now);
            CreateMap<CreateProductModel, Product>();

            CreateMap<UpdateStockModel, Stock>();
            CreateMap<UpdateProductModel, Product>();
        }
    }
}
