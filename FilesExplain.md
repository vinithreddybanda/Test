## .csproj

- an xml file
- info about the project 
- dependencies info
- build config
- target framwork
- etc

##### 1. `<Project Sdk="Microsoft.NET.Sdk.Web">`

- specifies the SDK that the project will use
- `Microsoft.NET.Sdk.Web` means it is an ASP.NET Core project
- with `web-specific configurations` and `dependencie`
- provides:
    - Tools
    - Lib
    - dependencies
    - To:
        - develop
        - build
        - run **`ASP.NET Core Web applications.`**

##### 2. `<PropertyGroup>`
 
- defines project properties
- affects how the project is built or configured
- Multiple PropertyGroup elements can exist in a .csproj file
- Properties within this group define aspects like:
    - target framework
    - nullable reference type handling
    - implicit using

##### 3. `<TargetFramework>net8.0</TargetFramework>:`

- defines the target framework that the project is built against
- pecifies which version of the .NET runtime your application will use

##### 4. `<Nullable>enable</Nullable>`

- enables nullable reference types for the project
- helps prevent null reference exceptions
    - making reference types (like a string, class, etc.) either explicitly nullable or non-nullable
- When enabled:
    - The compiler will give `warnings` if a potentially `null value is not handled properly`.
    - It makes code safer and more resilient to null-related runtime errors
    - clearly distinguishing which variables are `allowed to be null`

##### 5. `<ImplicitUsings>enable</ImplicitUsings>`

- automatically includes commonly used using directives
- ex: System, System.Collections.Generic, System.Linq, Microsoft.AspNetCore.Http, etc.
- System, System.Collections.Generic, System.Linq, Microsoft.AspNetCore.Http, etc.


##### 6. `<ItemGroup>`
-  define a group of items
    - package references
    - project references
    - folder references
    - ex: `<PackageReference Include=”Newtonsoft.Json” Version=”13.0.3″ />`

    ```csharp
    Once we delete that package, then it will delete the reference from both the Package Dependencies as well as from the project file.
    ```

## How to add Packages:

- add a nuget package :
    - **`dotnet add package <PackageName>`**
    - **`dotnet add package <PackageName> --version 6.0.0`**

- add project
    -  **`dotnet add <YourProject>.csproj reference <OtherProjectPath>.csproj`**
    - from the proj dir
    - **`dotnet add reference ..\OtherProject\OtherProject.csproj`**
    
