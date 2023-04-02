using MethodBoundaryAspect.Fody.App.Aspects;
using System;
using System.Threading.Tasks;

namespace MethodBoundaryAspect.Fody.App;

[LogAspect]
public class Sample
{
    public void Method()
    {
        ConsoleColor.Green.WriteLine($"Running '{nameof(Method)}'");
    }
        
    public void ExceptionMethod()
    {
        ConsoleColor.Green.WriteLine($"Running '{nameof(ExceptionMethod)}'");
        throw new InvalidOperationException();
    }

    public Task AnotherMethodAsync()
    {
        ConsoleColor.Green.WriteLine($"Running '{nameof(AnotherMethodAsync)}'");
        return Task.CompletedTask;
    }
}