using FluentValidation;
using Restaurants.Application.Command.CreateRestaurant;
using Restaurants.Application.Restaurants.Dtos;

public class CreateRestaurantCommandValidator
    : AbstractValidator<CreateRestaurantCommand>
{
    public CreateRestaurantCommandValidator()
    {
 
        RuleFor(x => x.ContactEmail)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.ContactEmail))
            .WithMessage("Invalid email format.");

        RuleFor(x => x.ContactNumber)
            .MinimumLength(6)
            .When(x => !string.IsNullOrWhiteSpace(x.ContactNumber));

     
        RuleFor(x => x.PostalCode)
            .Matches(@"^\d{2}_\d{3}$")
            .When(x => !string.IsNullOrWhiteSpace(x.PostalCode))
            .WithMessage("PostalCode must be in format XX_XXX (e.g., 12_345).");
    }
}