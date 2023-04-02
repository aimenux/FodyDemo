using System;
using System.Diagnostics;

namespace MethodBoundaryAspect.Fody.App;

public static class Extensions
{
    public static void WriteLine(this ConsoleColor color, object value)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
        Console.ResetColor();
    }

    public static void TryCatch(this Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"An error has occured {ex.Message}");
        }
    }
}