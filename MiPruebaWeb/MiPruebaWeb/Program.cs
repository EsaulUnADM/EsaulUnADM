using Microsoft.EntityFrameworkCore;
using MiPruebaWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// ** 1. Registro de Servicios (Services) **

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar EF Core con SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// ** 2. Construcción de la Aplicación **
var app = builder.Build();

// ** 3. Pipeline HTTP (Middleware) **

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();