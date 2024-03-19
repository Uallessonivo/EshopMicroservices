using Catalog.Api.Products.Queries.GetProductById.Query;
using Catalog.Api.Products.Queries.GetProductById.Result;

namespace Catalog.Api.Products.Queries.GetProductById;

internal class GetProductByIdQueryHandler(IQuerySession session) 
    : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        var product = await session.LoadAsync<Product>(query.Id, cancellationToken);
        if (product == null)
        {
            throw new ProductNotFoundException(query.Id);
        }
        return new GetProductByIdResult(product);
    }
}