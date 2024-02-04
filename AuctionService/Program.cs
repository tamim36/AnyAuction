using AuctionService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var str = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine("Conn string" + str);

builder.Services.AddDbContext<AuctionDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//https://gale.udemy.com/course/build-a-microservices-app-with-dotnet-and-nextjs-from-scratch/learn/lecture/
// 11 
