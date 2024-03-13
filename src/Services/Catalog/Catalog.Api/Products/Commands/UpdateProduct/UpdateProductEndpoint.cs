using Catalog.Api.Products.Commands.UpdateProduct.Command;
using Catalog.Api.Products.Commands.UpdateProduct.Response;
using Catalog.Api.Products.Commands.UpdateProduct.Result;

namespace Catalog.Api.Products.Commands.UpdateProduct;

public class UpdateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPut("/products", async (UpdateProductResult request, ISender sender) =>
            {
                var command = request.Adapt<UpdateProductCommand>();
                var result = await sender.Send(command);
                var response = result.Adapt<UpdateProductResponse>();
                return Results.Ok(response);
            })
            .WithName("UpdateProduct")
            .Produces<UpdateProductResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Updates a product")
            .WithDescription("Updates a product in the catalog");
    }
}