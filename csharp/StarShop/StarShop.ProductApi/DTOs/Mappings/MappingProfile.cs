using AutoMapper;
using StarShop.ProductApi.Models;

namespace StarShop.ProductApi.DTOs.Mappings;

public class MappingProfile: Profile
{
    public MappingProfile() {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<Product, ProductDTO>();
        CreateMap<Product, ProductDTO>().ForMember(x => x.CategoryName, opt => 
            opt.MapFrom(src => src.Category.Name));
    }
}
