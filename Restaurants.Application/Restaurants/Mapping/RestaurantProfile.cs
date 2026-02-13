

using AutoMapper;
using Restaurants.Application.Command.CreateRestaurant;
using Restaurants.Application.Queries.GetAllRestaurants;
using Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurants.Dtos;

public class RestaurantProfile : Profile
{
    public RestaurantProfile()
    {
        CreateMap<Restaurant, RestaurantDto>()
        .ForMember(dst => dst.City, opt => opt.MapFrom(src => src.Address == null ? null : src.Address.City))
        .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address == null ? null : src.Address.Street))
        .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address == null ? null : src.Address.PostalCode))
        .ForMember(dst => dst.Dishes, opt => opt.MapFrom(src => src.Dishes));

        CreateMap<CreateRestaurantCommand, Restaurant>()
            .ForMember(
                dest => dest.Address,
                opt => opt.MapFrom(src => new Address
                {
                    City = src.City,
                    Street = src.Street,
                    PostalCode = src.PostalCode
                })
            );

    }
}
