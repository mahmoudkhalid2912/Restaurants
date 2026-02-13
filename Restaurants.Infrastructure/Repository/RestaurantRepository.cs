using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;
using Restaurants.Infrastructure.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Repository;

public class RestaurantRepository(RestaurantDbContext dbContext) : IRestaurantRepository
{
    

    public async Task<IEnumerable<Restaurant>> GetAllAsync()
    {
        var resturants = await dbContext.Restaurants.ToListAsync();
        return resturants;
    }

    public Task<Restaurant?> GetByIdAsync(int id)
    {
        var restaurant = dbContext.Restaurants.Include(d=>d.Dishes).FirstOrDefaultAsync(r => r.Id == id);
        return restaurant;
    }

    public async Task CreateAsync(Restaurant restaurant)
    {
        dbContext.Restaurants.Add(restaurant);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Restaurant restaurant)
    {
        dbContext.Restaurants.Remove(restaurant);
        await dbContext.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    => await dbContext.SaveChangesAsync();
}
