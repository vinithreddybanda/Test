## 📦 .NET app types + CLI commands

From `powershell` in folder:

1. Web apps:
- Razor Pages: `dotnet new webapp -o MyWebApp`
- MVC: `dotnet new mvc -o MyMvcApp`
- Minimal API: `dotnet new web -o MyApiApp`
- Blazor Server: `dotnet new blazorserver -o MyBlazorServer`
- Blazor WebAssembly: `dotnet new blazorwasm -o MyBlazorWasm`

2. Desktop:
- WPF: `dotnet new wpf -o MyWpfApp`
- WinForms: `dotnet new winforms -o MyWinFormsApp`
- MAUI (if installed): `dotnet new maui -o MyMauiApp`

3. Console / library / worker:
- Console: `dotnet new console -o MyConsoleApp`
- Class library: `dotnet new classlib -o MyLib`
- Worker service: `dotnet new worker -o MyWorker`

4. API / microservice:
- gRPC: `dotnet new grpc -o MyGrpcApp`
- web (API only): `dotnet new webapi -o MyWebApi`
- worker: same as above `dotnet new worker`

## 🔧 Common commands (all types)
- `dotnet restore`
- `dotnet build`
- `dotnet run` or `dotnet run --project <path>`
- `dotnet publish -c Release -o ./publish`
- `dotnet test` (if test project exists)

## ℹ️ helpers
- list templates: `dotnet new --list`
- SDK info: `dotnet --info`