using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Extensions;


public static class ServiceCollectionExtenstions
{
    public static void AddApplication(this IServiceCollection services  )
    {
        var ApplicationAssimbly = typeof(ServiceCollectionExtenstions).Assembly;
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(ApplicationAssimbly));
        services.AddAutoMapper(ApplicationAssimbly);

        services.AddValidatorsFromAssembly(ApplicationAssimbly)
            .AddFluentValidationAutoValidation();
    }
}
