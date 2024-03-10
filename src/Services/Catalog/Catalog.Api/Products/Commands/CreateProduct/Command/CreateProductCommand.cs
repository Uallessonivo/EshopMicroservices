using Catalog.Api.Products.Commands.CreateProduct.Result;

namespace Catalog.Api.Products.Commands.CreateProduct.Command;

public record CreateProductCommand(
    string Name,
    List<string> Categories,
    string Description,
    string ImageFile,
    decimal Price) : ICommand<CreateProductResult>;