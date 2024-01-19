using Microsoft.EntityFrameworkCore;


using AetramTask2.Models;


var builder = WebApplication.CreateBuilder(args);


string connString = builder.Configuration.GetConnectionString("MyConStr");
builder.Services.AddDbContext<StoreDbContext>(item => item.UseSqlite(connString));
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ProductController}/{action=Index}/{id?}");
app.Run();