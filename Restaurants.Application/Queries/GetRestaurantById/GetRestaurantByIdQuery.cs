

using MediatR;
using Restaurants.Application.Queries.GetAllRestaurants;

namespace Restaurants.Application.Queries.GetRestaurantById;

public class GetRestaurantByIdQuery(int Id):IRequest<RestaurantDto?>
{
    public int Id { get; set; } = Id;
}
