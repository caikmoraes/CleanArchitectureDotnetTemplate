using Base.Clean.Template.Api;
using Base.Clean.Template.Application;
using Base.Clean.Template.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPresentation();
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
@*
#if (SwaggerSupport)
    app.UseSwagger();
    app.UseSwaggerUI();
#endif*@
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
