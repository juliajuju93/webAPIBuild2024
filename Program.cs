
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
    
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("1-0-0"   , new OpenApiInfo
    {
        Version = "1-0-0",
        Title = "webAPIBuild2024",
        Description = "An ASP.NET Core Demo Web API for Build 2024",
        Contact = new OpenApiContact
        {
            Name = "Julia Kasper",
            Email = "jukasper@microsoft.com"
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/1-0-0/swagger.json", "1-0-0");
        options.RoutePrefix = string.Empty;
    });


app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
