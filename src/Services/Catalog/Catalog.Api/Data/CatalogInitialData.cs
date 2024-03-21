using Marten.Schema;

namespace Catalog.Api.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        await using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync(token: cancellation))
            return;

        session.Store<Product>(GetPreConfiguredProducts());
        await session.SaveChangesAsync(cancellation);
    }

    private static IEnumerable<Product> GetPreConfiguredProducts() => new List<Product>
    {
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product 1",
            Description = "Description for Product 1",
            ImageFile = "product-1.png",
            Price = 100,
            Categories = ["Category 1", "Category 2"],
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product 2",
            Description = "Description for Product 2",
            ImageFile = "product-2.png",
            Price = 200,
            Categories = ["Category 2"],
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product 3",
            Description = "Description for Product 3",
            ImageFile = "product-3.png",
            Price = 300,
            Categories = ["Category 3"],
        },
    };
}