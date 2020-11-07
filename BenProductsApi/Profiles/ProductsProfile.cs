using AutoMapper;
using BenProductsApi.Dto;
using BenProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenProductsApi.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Products, ProductReadDto>();
            CreateMap<ProductCreateDto, Products>();
            CreateMap<ProductUpdateDto, Products>();
        }
    }
}
