using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger(options => options.PreSerializeFilters.Add((swagger, req) =>
    swagger.Servers = new List<OpenApiServer>{new OpenApiServer
        {Url = "https://backstage-demo-weather-api.azurewebsites.net"}}));
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
