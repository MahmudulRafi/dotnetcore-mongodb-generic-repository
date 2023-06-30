using Microsoft.Extensions.Options;
using MongoConnect.Models;
using MongoConnect.Repositories;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.Configure<MongoConnectionSetting>(builder.Configuration.GetSection(nameof(MongoConnectionSetting)));
builder.Services.AddSingleton<IMongoConnectionSetting>(sp => sp.GetRequiredService<IOptions<MongoConnectionSetting>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("MongoConnectionSetting:ConnectionString")));

builder.Services.AddScoped<IEmployeeRepository>(e => new EmployeeRepository(builder.Configuration.GetValue<string>("MongoConnectionSetting:ConnectionString")));
builder.Services.AddScoped<IDepartmentRepository>(e => new DepartmentRepository(builder.Configuration.GetValue<string>("MongoConnectionSetting:ConnectionString")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
