using HomeTaskViewModels.Models.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ViewDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ViewModelDB")));

var app = builder.Build();



app.MapControllerRoute(
    name: "default",
    pattern:"{controller=home}/{action=index}/{id?}");

app.UseStaticFiles();


app.Run();
