namespace TradeMarketDemo.Common.EntityModel;

public abstract class Entity<TId>(TId id)
    where TId : IEquatable<TId>
{
    public TId Id { get; private set; } = id;
}