public class Driver
{
    public int Id;
    public string Name;
    public double Rating;
    public bool IsAvailable;
    public int CancellationCount;

    public Driver(int id, string name, double rating)
    {
        Id = id;
        Name = name;
        Rating = rating;
        IsAvailable = true;
        CancellationCount = 0;
    }
}
