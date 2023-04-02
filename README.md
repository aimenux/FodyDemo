![.NET 5.0](https://github.com/aimenux/FodyDemo/workflows/.NET%205.0/badge.svg)

# FodyDemo
```
Playing with fody weaving library
```
> In this demo, i m playing with [Fody](https://github.com/Fody/Fody) weaving library.
>
> The solution consists of multiple apps using some of [fody plugins](https://github.com/Fody/Home/blob/master/pages/addins.md) :
>
> :one: `ToString.Fody.App` : in this app, i m using [ToString](https://github.com/Fody/ToString) in order to generate ToString implementation for decorated classes. Only public properties will be handled. The attribute `IgnoreDuringToString` can be used to exclude unwanted public properties.
> 
> :two: `PropertyChanged.Fody.App` : in this app, i m using [PropertyChanged](https://github.com/Fody/PropertyChanged) in order to raise property changed event in properties setters for classes implementing interface `INotifyPropertyChanged`.
>
> :three: `MethodTimer.Fody.App` : in this app, i m using [MethodTimer](https://github.com/Fody/MethodTimer) in order to measure methods execution time. The attribute `Time` is used to mark methods to be measured. The static class `MethodTimeLogger` is used to customize measure logs. 
> 
> :four: `MethodBoundaryAspect.Fody.App` : in this app, i m using [MethodBoundaryAspect](https://github.com/vescon/MethodBoundaryAspect.Fody) in order to implement aspects. The sample class use a logging aspect in order to log information before/after methods calling or when an exception is thrown.
>

**`Tools`** : vs22, net 6.0, fody