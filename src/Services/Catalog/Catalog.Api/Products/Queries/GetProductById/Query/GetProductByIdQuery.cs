using Catalog.Api.Products.Queries.GetProductById.Result;

namespace Catalog.Api.Products.Queries.GetProductById.Query;

public record GetProductByIdQuery(Guid Id) : IQuery<GetProductByIdResult>;