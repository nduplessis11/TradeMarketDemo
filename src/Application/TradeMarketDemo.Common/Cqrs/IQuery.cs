namespace TradeMarketDemo.Common.Cqrs;

public interface IQuery<out TResponse> where TResponse : notnull
{
}