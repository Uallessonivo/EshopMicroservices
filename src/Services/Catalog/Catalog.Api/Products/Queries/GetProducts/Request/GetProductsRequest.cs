namespace Catalog.Api.Products.Queries.GetProducts.Request;

public record GetProductsRequest(int? PageNumber = 1, int? PageSize = 10);