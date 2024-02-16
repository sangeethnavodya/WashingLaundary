using AutoMapper;
using WashingLaundary.Dtos.Customer;
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


        }
    }
}
