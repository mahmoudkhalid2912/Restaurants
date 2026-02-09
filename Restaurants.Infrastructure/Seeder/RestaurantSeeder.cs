
using Restaurants.Domain.Entities;
using Restaurants.Infrastructure.persistence;

namespace Restaurants.Infrastructure.Seeder;

public class RestaurantSeeder(RestaurantDbContext dbcontext) : IRestaurantSeeder
{
    public async Task SeedAsync()
    {
        if (await dbcontext.Database.CanConnectAsync())
        {
            if (!dbcontext.Restaurants.Any())
            {
                var Restaurants = GetRestaurants();
                await dbcontext.Restaurants.AddRangeAsync(Restaurants);
                await dbcontext.SaveChangesAsync();
            }
        }
    }


    private IEnumerable<Restaurant> GetRestaurants()
    {
        return new List<Restaurant>()
    {
        new Restaurant
        {
            Name = "Noma",
            Description = "Renowned for reinventing Nordic cuisine, based in Copenhagen, Denmark.",
            Category = "Fine Dining",
            HasDelivery = false,
            ContactEmail = "contact@noma.dk",
            ContactNumber = "+45 32 96 32 97",
            Address = new Address
            {
                City = "Copenhagen",
                Street = "Refshalevej 96",
                PostalCode = "1432"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Seaweed and Langoustine",
                    Description = "Innovative Nordic flavors with fresh langoustines and seaweed.",
                    Price = 35.00m
                },
                new Dish
                {
                    Name = "Fermented Cod",
                    Description = "Cod fermented and served with seasonal Nordic vegetables.",
                    Price = 42.50m
                }
            }
        },
        new Restaurant
        {
            Name = "El Celler de Can Roca",
            Description = "Creative Catalan cuisine, run by three Roca brothers, Girona, Spain.",
            Category = "Fine Dining",
            HasDelivery = false,
            ContactEmail = "info@cellercanroca.com",
            ContactNumber = "+34 972 22 21 57",
            Address = new Address
            {
                City = "Girona",
                Street = "Carrer de Can Sunyer 48",
                PostalCode = "17007"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Oyster and Caviar",
                    Description = "Fresh oysters paired with caviar and seasonal garnishes.",
                    Price = 38.00m
                },
                new Dish
                {
                    Name = "Lamb with Herbs",
                    Description = "Slow-cooked lamb with aromatic Catalan herbs.",
                    Price = 45.00m
                }
            }
        },
        new Restaurant
        {
            Name = "Osteria Francescana",
            Description = "Massimo Bottura's Michelin-starred restaurant in Modena, Italy.",
            Category = "Italian",
            HasDelivery = false,
            ContactEmail = "info@osteriafrancescana.it",
            ContactNumber = "+39 059 223912",
            Address = new Address
            {
                City = "Modena",
                Street = "Via Stella 22",
                PostalCode = "41121"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Five Ages of Parmigiano",
                    Description = "Parmesan cheese prepared in five different textures and ages.",
                    Price = 28.50m
                },
                new Dish
                {
                    Name = "OOPS! I Dropped the Lemon Tart",
                    Description = "Signature deconstructed lemon tart dessert.",
                    Price = 25.00m
                }
            }
        },
        new Restaurant
        {
            Name = "Eleven Madison Park",
            Description = "Iconic New York fine dining with innovative tasting menus.",
            Category = "Fine Dining",
            HasDelivery = false,
            ContactEmail = "contact@elevenmadisonpark.com",
            ContactNumber = "+1 212-889-0905",
            Address = new Address
            {
                City = "New York",
                Street = "11 Madison Ave",
                PostalCode = "10010"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Duck with Lavender",
                    Description = "Slow-roasted duck flavored with lavender and local spices.",
                    Price = 40.00m
                },
                new Dish
                {
                    Name = "Honey and Yogurt Dessert",
                    Description = "Creamy yogurt dessert with locally sourced honey.",
                    Price = 18.00m
                }
            }
        },
        new Restaurant
        {
            Name = "Mirazur",
            Description = "French Mediterranean cuisine with beautiful sea views, Menton, France.",
            Category = "French",
            HasDelivery = false,
            ContactEmail = "info@mirazur.fr",
            ContactNumber = "+33 4 92 41 86 86",
            Address = new Address
            {
                City = "Menton",
                Street = "30 Avenue Aristide Briand",
                PostalCode = "06500"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Seafood Risotto",
                    Description = "Freshly caught seafood with creamy risotto.",
                    Price = 36.00m
                },
                new Dish
                {
                    Name = "Lemon Tart",
                    Description = "Signature citrus dessert using local lemons.",
                    Price = 20.00m
                }
            }
        },
        new Restaurant
        {
            Name = "Gaggan",
            Description = "Progressive Indian cuisine in Bangkok, Thailand, world-famous.",
            Category = "Asian",
            HasDelivery = false,
            ContactEmail = "contact@gaggan.in",
            ContactNumber = "+66 92 416 4994",
            Address = new Address
            {
                City = "Bangkok",
                Street = "68/1 Soi Langsuan",
                PostalCode = "10330"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Yogurt Explosion",
                    Description = "Foam-like yogurt dish with popping Indian flavors.",
                    Price = 15.50m
                },
                new Dish
                {
                    Name = "Charcoal Lamb",
                    Description = "Smoky lamb served with aromatic Indian spices.",
                    Price = 28.00m
                }
            }
        },
        new Restaurant
        {
            Name = "Central",
            Description = "Peruvian gastronomy excellence in Lima, ranked among the best.",
            Category = "Peruvian",
            HasDelivery = false,
            ContactEmail = "info@centralrestaurante.com.pe",
            ContactNumber = "+51 1 242 8515",
            Address = new Address
            {
                City = "Lima",
                Street = "Calle Santa Isabel 376",
                PostalCode = "15047"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Amazonian Fish",
                    Description = "Fresh river fish with Amazonian herbs.",
                    Price = 22.00m
                },
                new Dish
                {
                    Name = "Potato Mosaic",
                    Description = "Creative Peruvian potato dish with seasonal ingredients.",
                    Price = 18.00m
                }
            }
        },
        new Restaurant
        {
            Name = "Disfrutar",
            Description = "Innovative tasting menus with creative Spanish cuisine, Barcelona.",
            Category = "Spanish",
            HasDelivery = false,
            ContactEmail = "info@disfrutarbarcelona.com",
            ContactNumber = "+34 933 48 68 06",
            Address = new Address
            {
                City = "Barcelona",
                Street = "Carrer de Villarroel 163",
                PostalCode = "08036"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Olive Sphere",
                    Description = "Molecular gastronomy dish with olive flavors.",
                    Price = 19.00m
                },
                new Dish
                {
                    Name = "Foie Gras Dessert",
                    Description = "Sweet and savory Spanish-inspired foie gras dessert.",
                    Price = 22.50m
                }
            }
        },
        new Restaurant
        {
            Name = "Arpège",
            Description = "Alain Passard's vegetable-focused French fine dining in Paris.",
            Category = "French",
            HasDelivery = false,
            ContactEmail = "contact@alain-passard.com",
            ContactNumber = "+33 1 47 05 09 06",
            Address = new Address
            {
                City = "Paris",
                Street = "84 Rue de Varenne",
                PostalCode = "75007"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Vegetable Garden Salad",
                    Description = "Fresh vegetables from Alain Passard's own gardens.",
                    Price = 20.00m
                },
                new Dish
                {
                    Name = "Carrot Velouté",
                    Description = "Creamy carrot soup with subtle spices.",
                    Price = 18.50m
                }
            }
        },
        new Restaurant
        {
            Name = "Pujol",
            Description = "Mexico City's top modern Mexican cuisine, blending tradition and innovation.",
            Category = "Mexican",
            HasDelivery = false,
            ContactEmail = "info@pujol.com.mx",
            ContactNumber = "+52 55 5545 4111",
            Address = new Address
            {
                City = "Mexico City",
                Street = "Tennyson 133",
                PostalCode = "Polanco 11550"
            },
            Dishes = new List<Dish>
            {
                new Dish
                {
                    Name = "Mole Madre",
                    Description = "Traditional mole sauce aged over time with local ingredients.",
                    Price = 24.00m
                },
                new Dish
                {
                    Name = "Taco de Ribeye",
                    Description = "Grilled ribeye tacos with gourmet toppings.",
                    Price = 19.50m
                }
            }
        }
    };
    }


}
