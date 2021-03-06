# About

Starting in C# 9, you don't have to explicitly include a Main method in a console application project. Instead, you can use the `top-level statements` feature to minimize the code you have to write. In this case, the compiler generates a class and Main method entry point for the application.

**See** Microsoft docs: [Top-level statements](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements)

# Included projects

- `BasicConsoleApp` demonstrates a basic top-level console project
- `BasicUsingInternalClassesApp` demonstrates accessing functionality with classes in the same project.
- `BasicEntityFrameworkCoreApp` provides a simple read from a SQL-Server database using [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- BasicConsoleWithLocalSwitchApp example using [switch expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression)
- WorkingWithDataConsoleApp shows working with
  - Class project `DataLibrary` to read json data
  - Class project `ContainerLibrary` with concrete classes used in `DataLibrary`

More code samples to be added shortly. 

# Requires

- [.NET Core](https://dotnet.microsoft.com/download) 5 or higher
- [Microsoft Visual Studio](https://visualstudio.microsoft.com/) 2019 or higher
- Newtonsoft.Json which can be swapped out for [System.Json](https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0)
- [SQL-Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) Express edition or better 