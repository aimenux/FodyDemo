using System;

namespace PropertyChanged.Fody.App;

public static class Program
{
    public static void Main()
    {
        var _ = new Sample("John", "Wick")
        {
            FirstName = "Walter",
            LastName = "White"
        };
        Console.WriteLine("\nPress any key to exit !");
        Console.ReadKey();
    }
}