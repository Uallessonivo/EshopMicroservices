using Catalog.Api.Products.Queries.GetProducts.Result;

namespace Catalog.Api.Products.Queries.GetProducts.Query;

public record GetProductsQuery() : IQuery<GetProductsResult>;