using EF_WEB_API.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);
var connectionString=builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("marketing", new OpenApiInfo
    {
        Title = "Marketing API",
        Version = "v1"
    });

    options.SwaggerDoc("setup", new OpenApiInfo
    {
        Title = "Setup API",
        Version = "v1"
    });

    options.DocInclusionPredicate((documentName, apiDescription) =>
    {
        return apiDescription.GroupName == documentName;
    });
});
builder.Services.AddDbContext<ProductDB>(options=>options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
    
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/marketing/swagger.json", "Marketing API");
        options.SwaggerEndpoint("/swagger/setup/swagger.json", "Setup API");
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
