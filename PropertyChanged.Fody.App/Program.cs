using System;

namespace PropertyChanged.Fody.App
{
    public static class Program
    {
        public static void Main()
        {
            var sample = new Sample("John", "Wick");
            sample.FirstName = "John";
            sample.LastName = "Snow";
            Console.WriteLine("\nPress any key to exit !");
            Console.ReadKey();
        }
    }
}
