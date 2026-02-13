using Restaurants.Application.Extensions;
using Restaurants.Infrastructure.Extensions;
using Restaurants.Infrastructure.Seeder;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();



var app = builder.Build();

var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<IRestaurantSeeder>();

await seeder.SeedAsync();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); 

app.Run();
