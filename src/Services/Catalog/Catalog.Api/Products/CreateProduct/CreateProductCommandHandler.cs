using BuildingBlocks.CQRS;
using Catalog.Api.Models;

namespace Catalog.Api.Products.CreateProduct;

internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // Create product
        var product = new Product
        {
            Name = command.Name,
            Categories = command.Categories,
            Description = command.Description,
            Price = command.Price
        };
        
        // TODO: Save product
        
        // Return result
        return new CreateProductResult(Guid.NewGuid());
    }
}