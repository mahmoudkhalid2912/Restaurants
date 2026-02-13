

using MediatR;

namespace Restaurants.Application.Command.UpdateRestaurant;

public class UpdateRestaurantCommand(int Id) : IRequest<bool>
{
    public int Id { get; set; } = Id;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Category { get; set; } = default!;

    public bool HasDelivery { get; set; }
}
