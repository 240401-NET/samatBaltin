namespace fastingTracker;

class Program
{
    static void Main(string[] args)
    {
        Record record1 = new Record (200.0, 135.8, 65.2, 100, 87, 5, 119, 78, 4, 4, "little headache");
        Console.WriteLine(record1.ToString());
    }
}
