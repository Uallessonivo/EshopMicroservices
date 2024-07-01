using Shopping.Web.Models.Ordering;

namespace Shopping.Web.Pages
{
    public class OrderListModel(IOrderingService orderingService, ILogger<OrderListModel> logger)
        : PageModel
    {
        public IEnumerable<OrderModel> Orders { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var customerId = Guid.NewGuid();
            var respone = await orderingService.GetOrdersByCustomer(customerId);

            Orders = respone.Orders;

            return Page();
        }
    }
}
