using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Command.DeleteRestaurant;

public class DeleteRestaurantCommand(int Id):IRequest<bool>
{
    public int Id { get; set; } = Id;
}
