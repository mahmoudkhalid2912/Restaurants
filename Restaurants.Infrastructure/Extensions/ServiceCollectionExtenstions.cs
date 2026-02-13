using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Domain.Repositories;
using Restaurants.Infrastructure.persistence;
using Restaurants.Infrastructure.Repository;
using Restaurants.Infrastructure.Seeder;


namespace Restaurants.Infrastructure.Extensions;

public static class ServiceCollectionExtenstions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var ConnectionString = configuration.GetConnectionString("RestaurantsDb");
        services.AddDbContext<RestaurantDbContext>(options =>
            options.UseSqlServer(ConnectionString));

            services.AddScoped<IRestaurantSeeder, RestaurantSeeder>();

        services.AddScoped<IRestaurantRepository, RestaurantRepository>();
    }
}
