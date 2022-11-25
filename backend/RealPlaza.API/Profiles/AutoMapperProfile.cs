using AutoMapper;
using RealPlaza.DataAccess.Complex;
//using RealPlaza.Dto.Response;
using RealPlaza.Entities;
//using RealPlaza.Dto.Request;

namespace RealPlaza.API.Profiles
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Product, ProductInfo>()
                .ForMember(dto => dto.Name, ent => ent.MapFrom(x => x.Name))
                .ForMember(dto => dto.Price, ent => ent.MapFrom(x => x.Price))
                .ForMember(dto => dto.Category, ent => ent.MapFrom(x => x.Category.Name))
                .ForMember(dto => dto.CreatedAt, ent => ent.MapFrom(x => x.CreatedAt.ToString("yyyy-MM-dd HH:mm")));

        }
    }
}