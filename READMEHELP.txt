Build a C# Solution.sln (SOLUTION): 

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new

dotnet new <TEMPLATE> [--dry-run] [--force] [-lang|--language {"C#"|"F#"|VB}]
    [-n|--name <OUTPUT_NAME>] [-f|--framework <FRAMEWORK>] [--no-update-check]
    [-o|--output <OUTPUT_DIRECTORY>] [--project <PROJECT_PATH>]
    [-d|--diagnostics] [--verbosity <LEVEL>] [Template options]

dotnet new <TEMPLATE> [-1|--list] [--type <TYPE>]

dotnet new -h--help

open the terminal
01. new solution folder:         mkdir "SolutionFolderName"
02. enter in solution folder:    cd "SolutionFolderName"
03. control folder path:         pwd
04. new possibilities:           dotnet new list
05. new solution:                dotnet new sln -n "SolutionName" -f "netN.0"
06. new console app:             dotnet new console -n "ConsoleName" -lang "C#" -f "netN.0"
07. new library app:             dotnet new classlib -n "LibraryName"  -lang "C#" -f "netN.0"
08. control folder content:      ls
09. add console app to solution: dotnet sln SolutionName.sln add ./ConsoleName/ConsoleName.csproj
10. add library app to solution: dotnet sln SolutionName.sln add ./LibraryName/LibraryName.csproj
11. add reference c->l:          dotnet add ConsoleName/ConsoleName.csproj reference LibraryName/LibraryName.csproj
12. enter in console app folder: cd "ConsoleFolderName"
13. open VSCode console app:     code .
14. install .vscode (launch and tasks)
15. enter in solution folder:    cd .. 
16. open VSCode solution:        code .
17. install .vscode (launch and tasks)
18. enter in console app folder: cd "ConsoleFolderName"
19. run console app:             dotnet run
20. add nuget pakages:           dotnet add package NuGetPackageName

examples:
dotnet7.0 console app: dotnet new console -n "ConsoleName" -lang "C#" -f "net7.0" --use-program-main
dotnet6.0 library app: dotnet new classlib -n "LibraryName" -lang "C#" -f "net6.0"