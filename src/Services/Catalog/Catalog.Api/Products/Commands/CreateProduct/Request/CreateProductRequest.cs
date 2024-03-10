namespace Catalog.Api.Products.Commands.CreateProduct.Request;

public record CreateProductRequest(string Name, List<string> Categories, string Description, string ImageFile, decimal Price);