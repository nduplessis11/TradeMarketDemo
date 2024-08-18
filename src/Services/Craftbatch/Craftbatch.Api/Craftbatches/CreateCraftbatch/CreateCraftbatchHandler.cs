using Craftbatch.Api.Models;

namespace Craftbatch.Api.Craftbatches.CreateCraftbatch;

public record CreateCraftbatchCommand(string Name, int Quantity, List<string> Items);

public record CreateCraftbatchResult(CraftbatchId CraftbatchId);

internal class CreateCraftbatchCommandHandler
{
    
}