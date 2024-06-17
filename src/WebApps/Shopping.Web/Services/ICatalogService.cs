namespace Shopping.Web.Services
{
    public interface ICatalogService
    {
        Task<GetProductsResponse> GetProducts(int? pageNumber = 1, int? pageSize = 10);
        Task<GetProductsByIdResponse> GetProducts(Guid id);
        Task<GetProductsByCategoryResponse> GetProductsByCategoryResponse(string category);
    }
}
