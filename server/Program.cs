using Wasi.AspNetCore.Server.CustomHost;

var builder = WebApplication.CreateBuilder(args).UseWasiCustomHostServer();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
