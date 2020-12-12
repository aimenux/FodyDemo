using System;
using System.Threading.Tasks;

namespace MethodBoundaryAspect.Fody.App
{
    public static class Program
    {
        public static async Task Main()
        {
            var sample = new Sample();
            sample.Method();
            await sample.AnotherMethodAsync();
            Console.WriteLine("\nPress any key to exit !");
            Console.ReadKey();
        }
    }
}
