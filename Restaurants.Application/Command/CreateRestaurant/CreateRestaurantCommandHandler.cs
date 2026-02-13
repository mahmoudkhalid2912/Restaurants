
using AutoMapper;
using MediatR;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Command.CreateRestaurant;

public class CreateRestaurantCommandHandler(IMapper mapper,IRestaurantRepository restaurantRepository) : IRequestHandler<CreateRestaurantCommand,int>
{
    public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
    {
        var restaurant = mapper.Map<Restaurant>(request);
        await restaurantRepository.CreateAsync(restaurant);
        return restaurant.Id;
    }
}
