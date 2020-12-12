![.NET 5.0](https://github.com/aimenux/FodyDemo/workflows/.NET%205.0/badge.svg)

# FodyDemo
```
Playing with Fody weaving library
```
> In this demo, i m playing with [Fody](https://github.com/Fody/Fody) weaving library.
>
> The solution consists of multiple apps, each one use some fody plugin :
> - `MethodBoundaryAspect.Fody.App` : in this app, i m using [MethodBoundaryAspect](https://github.com/vescon/MethodBoundaryAspect.Fody) in order to implement aspects. The sample class use a logging aspect in order to log information before/after methods calling or when an exception is thrown.
>

**`Tools`** : vs19, net 5.0, fody