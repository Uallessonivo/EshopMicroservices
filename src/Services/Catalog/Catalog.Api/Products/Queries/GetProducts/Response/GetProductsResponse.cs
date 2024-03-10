namespace Catalog.Api.Products.Queries.GetProducts.Response;

public record GetProductsResponse(IEnumerable<Product> Products);