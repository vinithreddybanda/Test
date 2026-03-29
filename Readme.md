### Program.cs

#### `var builder = WebApplication.CreateBuilder(args);:`

- creating the webhost and config services
- used to create an instance of the `WebApplicationBuilder sealed class`
- instance is responsible for configuring essential services:
    - Logging 
    - config
    - MVC
    - WebAPI
    - DI etc..
- Pre- confired defaults:
    - Webserver `Kestrel or IIS`
    - Host the App (inprocess or outofprocess)
    - Configuration (how to access `data` from the config files)
    - `DI container` - register built-in or custom services

#### `var app = builder.Build();:`
- building the app
- After configuring the services to app
- `Build()` method is called on the WebApplicationBuilder instance
- then the actual WebApplication instance is built
- We get `app`
- the `app` setups:
    - routes
    - middleware
    - starts handling request when runs

#### `app.MapGet(“/”, () => “Hello World!”);:`
- setup endpoints, routing and middleware for app
-  
