namespace EfCore8_SentinelValues.Database;

public sealed class Customer
{
    public int Id { get; init; }
    public Status Status { get; init; }
    public int Points { get; init; }
    public DateTime Created { get; init; }
}

public enum Status
{
    New = 1,
    Verified = 2,
    Deactivate = 3
}