using AutoMapper;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            CreateMap<ImportUserDto, User>();
            CreateMap<ImportProductDto, Product>();
            CreateMap<ImportCategoryDTO, Category>();
            CreateMap<ImportCategoryProduct, CategoryProduct>();
            
            CreateMap<Product, ExportProductsSold>();
            CreateMap<User,ExportUsersAndProductsSold>();
        }
    }
}
