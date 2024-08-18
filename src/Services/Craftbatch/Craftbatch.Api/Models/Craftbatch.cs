using TradeMarketDemo.Common.EntityModel;

namespace Craftbatch.Api.Models;

public class Craftbatch(CraftbatchId id) : Entity<CraftbatchId>(id)
{
    public string Name { get; private set; } = string.Empty;
    public static Craftbatch CreateNew() => new(CraftbatchId.NewCraftbatchId());
}

public readonly record struct CraftbatchId(Guid Id)
{
    public static CraftbatchId NewCraftbatchId() => new(Guid.NewGuid());
    public static CraftbatchId Empty => new(Guid.Empty);
}