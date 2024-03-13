namespace Catalog.Api.Products.Commands.UpdateProduct.Request;

public record UpdateProductRequest(    
    Guid Id,
    string Name,
    List<string> Categories,
    string Description,
    string ImageFile,
    decimal Price);