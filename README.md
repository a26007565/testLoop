# Loop performance

## Result

``` ini
BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.6 (18G84) [Darwin 18.7.0]
Intel Core i5-5257U CPU 2.70GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.301
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
```

|               Method |         Mean |       Error |      StdDev |       Median | Rank |
|--------------------- |-------------:|------------:|------------:|-------------:|-----:|
|       ForEachOnArray |     7.690 ns |   0.2706 ns |   0.7631 ns |     7.479 ns |    1 |
| ForEachOnIEnumerable | 5,830.423 ns | 272.4527 ns | 768.4577 ns | 5,597.898 ns |    3 |
|              LinqSum |    89.718 ns |   1.3162 ns |   1.1668 ns |    89.417 ns |    2 |
