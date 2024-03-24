namespace basket.Api.Basket.DeleteBasket;

public class DeleteBasketCommandHandler(IBasketRepository repository) : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
{
    public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
    {
        await repository.DeleteBasket(command.UserName, cancellationToken);
        return new DeleteBasketResult(true);
    }
}