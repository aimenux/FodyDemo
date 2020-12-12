using System;
using System.Collections.Generic;

namespace ToString.Fody.App
{
    public static class Program
    {
        public static void Main()
        {
            var sample = BuildSample();
            Console.WriteLine(sample);
            Console.WriteLine("\nPress any key to exit !");
            Console.ReadKey();
        }

        private static Sample BuildSample()
        {
            return new Sample
            {
                Title = "UberEats",
                SecretKey = Guid.NewGuid(),
                Items = new List<Item>
                {
                    new Item
                    {
                        Description = "Wok",
                        Quantity = 1,
                        UnitPrice = 12.5m,
                        EndDate = DateTime.Now.AddDays(1)
                    },
                    new Item
                    {
                        Description = "Sushi",
                        Quantity = 2,
                        UnitPrice = 14.5m,
                        EndDate = DateTime.Now.AddDays(2)
                    }
                }
            };
        }
    }
}
