namespace basket.Api.Basket.GetBasket;

public record GetBasketQuery(string UserName) : IQuery<GetBasketResult>;