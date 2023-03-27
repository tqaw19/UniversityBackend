using Microsoft.EntityFrameworkCore;
using University.DataAccess;
using University.Controllers;
using University.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add service of JWT authtorization
// TODO:
//builder.Services.AddJwtTokenServices(builder.Configuration);

// TODO: Connection with SQL Server Express
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// Add Context
builder.Services.AddDbContext<UniveristyDBContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.

builder.Services.AddControllers();

// Add Custom Services (folder Services)
builder.Services.AddScoped<IStudentService, StudentService>();
// TODO: Add the rest of services


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// TODO: Config Swagger to take care of Authorization of JWT
builder.Services.AddSwaggerGen();

// CORS Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

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

// Tell app to use CORS
app.UseCors("CorsPolicy");

app.Run();
