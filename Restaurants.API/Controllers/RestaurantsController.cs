
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Command.CreateRestaurant;
using Restaurants.Application.Command.DeleteRestaurant;
using Restaurants.Application.Command.UpdateRestaurant;
using Restaurants.Application.Queries.GetAllRestaurants;
using Restaurants.Application.Queries.GetRestaurantById;
using Restaurants.Application.Restaurants.Dtos;



namespace Restaurants.API.Controllers;

[Route("api/restaurants")]
[ApiController]
public class RestaurantsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var restaurants = await mediator.Send(new GetAllRestaurantsQuery());

        return Ok(restaurants);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var restaurant = await mediator.Send(new GetRestaurantByIdQuery(id));
        if (restaurant is null)
            return NotFound();
        return Ok(restaurant);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateRestaurantCommand command)
    {
        var id = await mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { Id = id }, null);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var IsDeleted = await mediator.Send(new DeleteRestaurantCommand(id));
        if (!IsDeleted)
            return NotFound();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateRestaurantCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var IsUpdated = await mediator.Send(command);
        if (!IsUpdated)
            return NotFound();
        return NoContent();
    }

}