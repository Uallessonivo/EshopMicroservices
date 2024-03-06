namespace Catalog.Api.Products.CreateProduct.Request;

public record CreateProductRequest(string Name, List<string> Categories, string Description, string ImageFile, decimal Price);