using Catalog.Api.Products.Commands.CreateProduct.Command;
using Catalog.Api.Products.Commands.CreateProduct.Result;

namespace Catalog.Api.Products.Commands.CreateProduct;

internal class CreateProductCommandHandler(
    IDocumentSession session,
    Logger<CreateProductCommandHandler> logger)
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("CreateProductCommandHandler.Handle called with {@Command}", command);

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