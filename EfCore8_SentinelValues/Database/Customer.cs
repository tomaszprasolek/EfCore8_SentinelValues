namespace EfCore8_SentinelValues.Database;

public sealed class Customer
{
    private readonly int? _points;
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public Status Status { get; init; }

    public int Points
    {
        get => _points ?? 10;
        init => _points = value;
    }

    public DateTime Created { get; init; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, status: {Status}, points: {Points}";
    }
}