namespace MethodTimer.Fody.App;

public static class Program
{
    public static void Main()
    {
        var sample = new Sample();
        sample.SomeMethod();
        sample.SyncSomeMethodAsync();
        Console.WriteLine("\nPress any key to exit !");
        Console.ReadKey();
    }
}