using Catalog.Api.Products.Commands.DeleteProduct.Result;

namespace Catalog.Api.Products.Commands.DeleteProduct.Command;

public record DeleteProductCommand(Guid Id) : ICommand<DeleteProductResult>;