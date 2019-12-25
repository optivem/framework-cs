﻿using AutoMapper;
using Optivem.Template.Core.Application.Products.Queries;
using Optivem.Template.Core.Domain.Products;

namespace Optivem.Template.Infrastructure.Mapping.Products
{
    public class FindProductResponseProfile : Profile
    {
        public FindProductResponseProfile()
        {
            CreateMap<Product, FindProductResponse>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(e => e.ProductCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(e => e.ProductName))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(e => e.ListPrice));
        }
    }
}