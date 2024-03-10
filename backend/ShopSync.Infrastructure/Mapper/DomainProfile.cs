using AutoMapper;
using ShopSync.Domain.DTOs;
using ShopSync.Domain.Entities;

namespace ShopSync.Infrastructure.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            // Map all properties
            CreateMap<Product, ProductDTO>().ReverseMap();

            // Map specific properties
            // CreateMap<ProductDTO, Product>().ReverseMap()
            // .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            // .ForPath(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            // .ForPath(dest => dest.BriefDescription, opt => opt.MapFrom(src => src.BriefDescription))
            // .ForPath(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            // .ForPath(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
            // .ForPath(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand))
            // .ForPath(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));
        }
    }
}