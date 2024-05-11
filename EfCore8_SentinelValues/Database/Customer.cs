namespace EfCore8_SentinelValues.Database;

public sealed class Customer
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public Status Status { get; init; }
    public int Points { get; init; }
    public DateTime Created { get; init; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, status: {Status}, points: {Points}";
    }
}