namespace Ordering.Application.Extensions
{
    public static class OrderExtensions
    {
        public static IEnumerable<OrderDto> ToOrderDtoList(this IEnumerable<Order> orders)
        {
            return orders.Select(order => new OrderDto(
                Id: order.Id.Value,
                CustomerId: order.CustomerId.Value,
                OrderName: order.OrderName.Value,
                ShippingAddress: new AddressDto(
                        order.ShippingAddres.FirstName,
                        order.ShippingAddres.LastName,
                        order.ShippingAddres.EmailAddress,
                        order.ShippingAddres.AddressLine,
                        order.ShippingAddres.Country,
                        order.ShippingAddres.State,
                        order.ShippingAddres.ZipCode
                        ),
                BillingAddress: new AddressDto(
                        order.BillingAddress.FirstName,
                        order.BillingAddress.LastName,
                        order.BillingAddress.EmailAddress,
                        order.BillingAddress.AddressLine,
                        order.BillingAddress.Country,
                        order.BillingAddress.State,
                        order.BillingAddress.ZipCode
                        ),
                Payment: new PaymentDto(
                        order.Payment.CardName,
                        order.Payment.CardNumber,
                        order.Payment.Expiration,
                        order.Payment.CVV,
                        order.Payment.PaymentMethod
                        ),
                Status: order.Status,
                OrderItems: order.OrderItems.Select(oi => new OrderItemDto(oi.OrderId.Value, oi.ProductId.Value, oi.Quantity, oi.Price)).ToList()));
        }

        public static OrderDto ToOrderDto(this Order order)
        {
            return DtoFromOrder(order);
        }

        public static OrderDto DtoFromOrder(Order order)
        {
            return new OrderDto(
                Id: order.Id.Value,
                CustomerId: order.CustomerId.Value,
                OrderName: order.OrderName.Value,
                ShippingAddress: new AddressDto(
                        order.ShippingAddres.FirstName,
                        order.ShippingAddres.LastName,
                        order.ShippingAddres.EmailAddress,
                        order.ShippingAddres.AddressLine,
                        order.ShippingAddres.Country,
                        order.ShippingAddres.State,
                        order.ShippingAddres.ZipCode
                        ),
                BillingAddress: new AddressDto(
                        order.BillingAddress.FirstName,
                        order.BillingAddress.LastName,
                        order.BillingAddress.EmailAddress,
                        order.BillingAddress.AddressLine,
                        order.BillingAddress.Country,
                        order.BillingAddress.State,
                        order.BillingAddress.ZipCode
                        ),
                Payment: new PaymentDto(
                        order.Payment.CardName,
                        order.Payment.CardNumber,
                        order.Payment.Expiration,
                        order.Payment.CVV,
                        order.Payment.PaymentMethod
                        ),
                Status: order.Status,
                OrderItems: order.OrderItems.Select(oi => new OrderItemDto(oi.OrderId.Value, oi.ProductId.Value, oi.Quantity, oi.Price)).ToList());
        }
    }
}
