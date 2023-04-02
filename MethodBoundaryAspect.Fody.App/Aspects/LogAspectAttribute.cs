using MethodBoundaryAspect.Fody.Attributes;
using System;

namespace MethodBoundaryAspect.Fody.App.Aspects;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public sealed class LogAspectAttribute : OnMethodBoundaryAspect
{
    public override void OnEntry(MethodExecutionArgs args)
    {
        ConsoleColor.Gray.WriteLine($"[{ExtractCallerName(args)}] {nameof(OnEntry)}");
    }

    public override void OnExit(MethodExecutionArgs args)
    {
        ConsoleColor.Gray.WriteLine($"[{ExtractCallerName(args)}] {nameof(OnExit)}");
    }

    public override void OnException(MethodExecutionArgs args)
    {
        ConsoleColor.Gray.WriteLine($"[{ExtractCallerName(args)}] {nameof(OnException)}");
    }

    private static string ExtractCallerName(MethodExecutionArgs args)
    {
        var @class = args.Instance.GetType().Name;
        var @method = args.Method.Name;
        return $"{@class}.{@method}";
    }
}