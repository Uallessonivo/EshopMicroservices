using Catalog.Api.Products.Commands.UpdateProduct.Result;

namespace Catalog.Api.Products.Commands.UpdateProduct.Command;

public record UpdateProductCommand(
    Guid Id,
    string Name,
    List<string> Categories,
    string Description,
    string ImageFile,
    decimal Price) : ICommand<UpdateProductResult>;