using Catalog.Api.Products.Queries.GetProducts.Result;

namespace Catalog.Api.Products.Queries.GetProducts.Query;

public record GetProductsQuery(int? PageNumber = 1, int? PageSize = 10) : IQuery<GetProductsResult>;