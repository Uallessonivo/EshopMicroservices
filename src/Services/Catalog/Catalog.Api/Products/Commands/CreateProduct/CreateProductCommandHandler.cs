using Catalog.Api.Products.Commands.CreateProduct.Command;
using Catalog.Api.Products.Commands.CreateProduct.Result;

namespace Catalog.Api.Products.Commands.CreateProduct;

internal class CreateProductCommandHandler(
    IDocumentSession session,
    Logger<CreateProductCommandHandler> logger,
    IValidator<CreateProductCommand> validator)
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("CreateProductCommandHandler.Handle called with {@Command}", command);

        var result = await validator.ValidateAsync(command, cancellationToken);
        var errors = result.Errors.Select(x => x.ErrorMessage).ToList();

        if (errors.Count != 0)
        {
            logger.LogWarning("CreateProductCommandHandler.Handle validation failed with errors: {@Errors}", errors);
            throw new ValidationException(errors.FirstOrDefault());
        }

        var product = new Product
        {
            Name = command.Name,
            Categories = command.Categories,
            Description = command.Description,
            Price = command.Price
        };

        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        return new CreateProductResult(product.Id);
    }
}