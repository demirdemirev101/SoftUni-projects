using AutoMapper;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;

namespace CarDealer
{
    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            CreateMap<ImportSupplierDto, Supplier>();
            CreateMap<ImportPartDto, Part>();
            CreateMap<ImportCarDto, Car>();
            CreateMap<ImportCustomerDto, Customer>();
            CreateMap<ImportSaleDto, Sale>();

            CreateMap<Car, ExportCarsWithDistance>();
            CreateMap<Car, ExportBWMCars>();
            CreateMap<Supplier, ExportLocalSuppliers>();
            CreateMap<Part, PartsDto>();
            CreateMap<Car, ExportCarPartsDto>();
        }
    }
}
