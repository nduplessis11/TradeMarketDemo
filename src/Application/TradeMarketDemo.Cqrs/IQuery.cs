namespace TradeMarketDemo.Cqrs;

public interface IQuery<out TResponse> where TResponse : notnull
{
}