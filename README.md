# IEnumerable.ForEach
C# ForEach extension for IEnumerable type.

# Usage

## Installing the Package

#### Visual Studio Package Manager
Please follow the instructions on [NuGet documentation](https://docs.microsoft.com/en-us/nuget/tools/package-manager-ui).  
Search for `IEnumerable.ForEach` and install the package to your project.

#### Visual Studio Package Manager Console
Launch Visual Studio 2015+ and then launch Package Manager Console.  
`PM> Install-Package IEnumerable.ForEach`

#### Dotnet CLI
`PS> dotnet add package IEnumerable.ForEach`

## Importing the Namespace
`using IEnumerable.ForEach;`

## Using
The following program deletes all the files in a directory without the need for a `foreach` loop -  
```
using System;
using System.IO;
using IEnumerable.ForEach;

namespace Sample
{
  class Program
  {
    static void Main(string[] args)
    {
      var dest = @"F:\demo\folder";
      if (Directory.Exists(dest))
      {
        Console.WriteLine("Deleting files...");
        Directory.GetFiles(dest).ForEach(e => File.Delete(e));
      }
    }
  }
}
```