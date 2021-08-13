namespace Lab.Framework.Mapper.Profiles
{
    using AutoMapper;
    using Dto;
    using Entities;

    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Discount, DiscountDto>();
        }
    }
}