using TradeMarketDemo.Common.EntityModel;

namespace Craftbatch.Api.Models;

public class Craftbatch(CraftbatchId id) : Entity<CraftbatchId>(id)
{
    public string Name { get; private set; } = string.Empty;
    public int Quantity { get; private set; } = 0;
    public CraftbatchStatus Status { get; private set; } = CraftbatchStatus.Pending;
    public List<string> Items { get; private set; } = [];
    
    public static Craftbatch CreateNew() => new(CraftbatchId.NewCraftbatchId());
}

public readonly record struct CraftbatchId(Guid Id)
{
    public static CraftbatchId NewCraftbatchId() => new(Guid.NewGuid());
    public static CraftbatchId Empty => new(Guid.Empty);
}

public enum CraftbatchStatus
{
    Pending,
    Live,
    SoldOut
}