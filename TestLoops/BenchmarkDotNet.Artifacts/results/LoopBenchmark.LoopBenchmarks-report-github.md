```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-10870H CPU 2.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method    | Mean     | Error    | StdDev   | Allocated |
|---------- |---------:|---------:|---------:|----------:|
| ForLoop   | 57.17 ns | 0.573 ns | 0.478 ns |         - |
| WhileLoop | 58.75 ns | 0.754 ns | 0.669 ns |         - |
