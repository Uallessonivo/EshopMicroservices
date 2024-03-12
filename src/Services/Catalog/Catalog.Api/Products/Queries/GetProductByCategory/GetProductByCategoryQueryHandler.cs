using Catalog.Api.Products.Queries.GetProductByCategory.Query;
using Catalog.Api.Products.Queries.GetProductByCategory.Result;

namespace Catalog.Api.Products.Queries.GetProductByCategory;

internal class GetProductByCategoryQueryHandler(IQuerySession session, ILogger<GetProductByCategoryQueryHandler> logger) 
    : IQueryHandler<GetProductByCategoryQuery, GetProductByCategoryResult>
{
    public async Task<GetProductByCategoryResult> Handle(GetProductByCategoryQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductByCategoryQueryHandler.Handle called with {@Query}", query);
        var products = await session.Query<Product>()
            .Where(p => p.Categories.Contains(query.Category))
            .ToListAsync(cancellationToken);
        return new GetProductByCategoryResult(products);
    }
}