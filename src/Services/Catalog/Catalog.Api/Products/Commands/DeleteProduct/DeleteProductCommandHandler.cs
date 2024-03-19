using Catalog.Api.Products.Commands.DeleteProduct.Command;
using Catalog.Api.Products.Commands.DeleteProduct.Result;

namespace Catalog.Api.Products.Commands.DeleteProduct;

internal class DeleteProductCommandHandler(IDocumentSession session)
    : ICommandHandler<DeleteProductCommand, DeleteProductResult>
{
    public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {
        session.Delete<Product>(command.Id);
        await session.SaveChangesAsync(cancellationToken);
        return new DeleteProductResult(true);
    }
}