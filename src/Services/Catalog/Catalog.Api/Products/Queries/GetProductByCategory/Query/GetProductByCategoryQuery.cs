using Catalog.Api.Products.Queries.GetProductByCategory.Result;

namespace Catalog.Api.Products.Queries.GetProductByCategory.Query;

public record GetProductByCategoryQuery(string Category) : IQuery<GetProductByCategoryResult>;