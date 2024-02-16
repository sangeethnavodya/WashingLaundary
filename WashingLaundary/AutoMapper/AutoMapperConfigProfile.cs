using AutoMapper;
using WashingLaundary.Dtos.Customer;
using WashingLaundary.Dtos.NewFolder;
using WashingLaundary.Entity;

namespace WashingLaundary.AutoMapper
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            //Customer
            CreateMap<CustomerCreateDto, Customer>();

            CreateMap<Customer, CustomerGetDto>();

            //Clothes

            CreateMap<ClothesCreateDto, Clothes>();

            CreateMap<Clothes, ClothesGetDto>()
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer.Name));


        }
    }
}
