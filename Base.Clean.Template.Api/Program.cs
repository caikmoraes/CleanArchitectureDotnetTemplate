using Base.Clean.Template.Api;
using Base.Clean.Template.Application;
using Base.Clean.Template.Infrastructure;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPresentation();
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

app.UseSwagger(options => { options.RouteTemplate = "openapi/{documentName}.json"; });
app.MapScalarApiReference();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();