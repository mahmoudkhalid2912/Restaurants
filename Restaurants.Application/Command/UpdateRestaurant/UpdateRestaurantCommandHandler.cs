using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Command.UpdateRestaurant;

public class UpdateRestaurantCommandHandler(ILogger<UpdateRestaurantCommandHandler>logger,
    IRestaurantRepository restaurantRepository,IMapper mapper) : IRequestHandler<UpdateRestaurantCommand, bool>
{
    public async Task<bool> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
    {
        var restaurant = await restaurantRepository.GetByIdAsync(request.Id);
        if (restaurant is null)
        {
            logger.LogError("Restaurant with id {Id} not found", request.Id);
            return false;

        }
        else
        {
            mapper.Map(request, restaurant);
            await restaurantRepository.SaveChangesAsync();
            logger.LogInformation("Restaurant with id {Id} updated successfully", request.Id);
            return true;
        }
    }
}
