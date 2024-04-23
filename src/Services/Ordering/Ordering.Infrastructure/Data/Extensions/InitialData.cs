namespace Ordering.Infrastructure.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<Customer> Customers => new List<Customer>
        {
            Customer.Create(CustomerId.Of(Guid.NewGuid()), "Person one", "person_one@gmail.com"),
            Customer.Create(CustomerId.Of(Guid.NewGuid()), "Person two", "person_two@gmail.com")
        };

        public static IEnumerable<Product> Products => new List<Product>
        {
            Product.Create(ProductId.Of(Guid.NewGuid()), "Product one", 1000),
            Product.Create(ProductId.Of(Guid.NewGuid()), "Product two", 2000)
        };

        public static IEnumerable<Order> OrdersWithItems
        {
            get
            {
                var address1 = Address.Of("john", "doe", "johndoe@gmail.com", "Broadway No.12", "England", "Nottingham", "08050");
                var address2 = Address.Of("mario", "delame", "mariodelame@gmail.com", "Broadway No.12", "England", "Nottingham", "08050");

                var payment1 = Payment.Of("john", "55555555555555555444", "12/28", "555", 1);
                var payment2 = Payment.Of("mario", "44444444444444444445", "08/28", "355", 2);

                var order1 = Order.Create(
                    OrderId.Of(Guid.NewGuid()),
                    CustomerId.Of(Guid.NewGuid()),
                    OrderName.Of("Order 1"),
                    shippingAddres: address1,
                    billingAddress: address1,
                    payment2);

                order1.Add(ProductId.Of(Guid.NewGuid()), 2, 500);
                order1.Add(ProductId.Of(Guid.NewGuid()), 3, 600);

                var order2 = Order.Create(
                    OrderId.Of(Guid.NewGuid()),
                    CustomerId.Of(Guid.NewGuid()),
                    OrderName.Of("Order 2"),
                    shippingAddres: address2,
                    billingAddress: address2,
                    payment1);

                order2.Add(ProductId.Of(Guid.NewGuid()), 1, 500);
                order2.Add(ProductId.Of(Guid.NewGuid()), 3, 600);

                return new List<Order> { order1, order2 };
            }
        }
    }
}
