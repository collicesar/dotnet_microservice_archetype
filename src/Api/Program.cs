var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.RegisterModules();
builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapEndpoints();

app.MapHealthChecks("/health");

app.Run();
