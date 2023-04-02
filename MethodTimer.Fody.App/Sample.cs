using System.Reflection;

namespace MethodTimer.Fody.App;

public class Sample
{
    private const int DefaultMaxRetries = 10;
    
    private static readonly TimeSpan Delay = TimeSpan.FromMilliseconds(50);
    
    [Time("Retries {retries} time(s)")]
    public void SomeMethod(int retries = DefaultMaxRetries)
    {
        ConsoleColor.Green.WriteLine($"Running '{nameof(SomeMethod)}'");
        for (var index = 0; index < retries; index ++)
        {
            Thread.Sleep(Delay);
        }
    }
    
    [Time("Retries {retries} time(s)")]
    public async Task SomeMethodAsync(int retries, CancellationToken cancellationToken)
    {
        ConsoleColor.Green.WriteLine($"Running '{nameof(SomeMethodAsync)}'");
        for (var index = 0; index < retries; index ++)
        {
            await Task.Delay(Delay, cancellationToken);
        }
    }

    public void SyncSomeMethodAsync(int retries = DefaultMaxRetries)
    {
        SomeMethodAsync(retries, CancellationToken.None).GetAwaiter().GetResult();
        Thread.Sleep(Delay * retries);
    }
}

public static class MethodTimeLogger
{
    public static void Log(MethodBase methodBase, TimeSpan elapsed, string message)
    {
        ConsoleColor.Yellow.WriteLine($"{methodBase.Name} [{message}] took {elapsed:g}");
    }
}