![.NET 5.0](https://github.com/aimenux/FodyDemo/workflows/.NET%205.0/badge.svg)

# FodyDemo
```
Playing with fody weaving library
```
> In this demo, i m playing with [Fody](https://github.com/Fody/Fody) weaving library.
>
> The solution consists of multiple apps using some of [fody plugins](https://github.com/Fody/Home/blob/master/pages/addins.md) :
> - `MethodBoundaryAspect.Fody.App` : in this app, i m using [MethodBoundaryAspect](https://github.com/vescon/MethodBoundaryAspect.Fody) in order to implement aspects. The sample class use a logging aspect in order to log information before/after methods calling or when an exception is thrown.
> - `ToString.Fody.App` : in this app, i m using [ToString](https://github.com/Fody/ToString) in order to generate ToString implementation for decorated classes. Only public properties will be handled. The attribute `IgnoreDuringToString` can be used to exclude unwanted public properties.
> - `PropertyChanged.Fody.App` : in this app, i m using [PropertyChanged](https://github.com/Fody/PropertyChanged) in order to generate boilerplate code raising property changed event in properties setters for classes implementing interface `INotifyPropertyChanged`.
>

**`Tools`** : vs19, net 5.0, fody