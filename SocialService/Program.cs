using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SocialService.Models;

var builder = WebApplication.CreateBuilder(args);

string con = "Server=(localdb)\\mssqllocaldb;Database=friendsdb1;Trusted_Connection=True;";
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(con));
builder.Services.AddControllers();

var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseRouting();

app.MapControllers();

app.Run();
