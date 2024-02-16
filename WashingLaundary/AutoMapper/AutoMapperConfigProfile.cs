using AutoMapper;
using WashingLaundary.Dtos.Customer;
using WashingLaundary.Models;

namespace WashingLaundary.AutoMapper
{
    public class AutoMapperConfigProfile: Profile
    {

        public AutoMapperConfigProfile()
        {
            CreateMap<CustomerCreateDto,Customer>();

            CreateMap<Customer,CustomerGetDto>();

        }

    }
}
