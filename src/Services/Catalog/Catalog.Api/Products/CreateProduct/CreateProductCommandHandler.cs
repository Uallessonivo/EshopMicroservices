namespace Catalog.Api.Products.CreateProduct;

internal class CreateProductCommandHandler(IDocumentSession session) : ICommandHandler<CreateProductCommand, CreateProductResult>
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
        
        // Save product
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);
        
        // Return result
        return new CreateProductResult(product.Id);
    }
}