using AutoMapper;
using ExampleCleanArchitecture.Application.Features.Products.Commands.CreateProduct;
using ExampleCleanArchitecture.Application.Features.Products.Queries.GetAllProducts;
using ExampleCleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCleanArchitecture.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
