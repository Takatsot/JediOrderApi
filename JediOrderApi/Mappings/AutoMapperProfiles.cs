using AutoMapper;
using JediOrderApi.Models.Domain;
using JediOrderApi.Models.DTO;

namespace JediOrderApi.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Products, ProductsResponse>().ReverseMap();
            CreateMap<AddProductRequest, Products>().ReverseMap();
            CreateMap<Reviews, ReviewResponse>().ReverseMap();
            CreateMap<AddReviewsRequest, Reviews>().ReverseMap();
        }
    }
}
