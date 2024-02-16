using AutoMapper;

namespace WashingLaundary.AutoMapper
{
    public class AutoMapperConfigProfile: Profile
    {

        public AutoMapperConfigProfile()
        {
            CreateMap<WashingLaundary.Models.Customer, WashingLaundary.Dtos.Customer.CustomerCreateDto>();
            CreateMap<WashingLaundary.Dtos.Customer.CustomerCreateDto, WashingLaundary.Models.Customer>();
        }

    }
}
