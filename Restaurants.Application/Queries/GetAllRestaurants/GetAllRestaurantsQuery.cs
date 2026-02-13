

using MediatR;

namespace Restaurants.Application.Queries.GetAllRestaurants;

public class GetAllRestaurantsQuery:IRequest<IEnumerable<RestaurantDto>>
{

}
