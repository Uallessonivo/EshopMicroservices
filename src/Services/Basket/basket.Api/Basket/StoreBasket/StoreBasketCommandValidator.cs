namespace basket.Api.Basket.StoreBasket;

public class StoreBasketCommandValidator : AbstractValidator<StoreBasketCommand>
{
    public StoreBasketCommandValidator()
    {
        RuleFor(x => x.Cart)
            .NotNull().WithMessage("Cart cannot be null");

        RuleFor(x => x.Cart.UserName)
            .NotEmpty().WithMessage("UserName cannot be empty");
    }
}