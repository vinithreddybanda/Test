//unchecked Do not use top-level statements
//creating the webhost and service into builder
var builder = WebApplication.CreateBuilder(args);

//build the application 
var app = builder.Build();


//set up endpoints, routing , midddlewares
app.MapGet("/", () => "Hello World!");


//run the app
app.Run();
