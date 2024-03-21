using Catalog.Api.Products.Queries.GetProducts.Query;
using Catalog.Api.Products.Queries.GetProducts.Result;

namespace Catalog.Api.Products.Queries.GetProducts;

internal class GetProductsQueryHandler(IQuerySession session)
    : IQueryHandler<GetProductsQuery, GetProductsResult>
{
    public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        var products = await session.Query<Product>()
            .ToPagedListAsync(query.PageNumber ?? 1, query.PageSize ?? 10, cancellationToken);
        return new GetProductsResult(products);
    }
}