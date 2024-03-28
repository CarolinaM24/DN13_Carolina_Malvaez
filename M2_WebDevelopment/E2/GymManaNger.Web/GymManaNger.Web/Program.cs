using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//string connectionString = builder.Configuration.GetConnectionString("Default");

// Configurar servicios
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization(); // Si es necesario para tu aplicación
builder.Services.AddRazorPages(); // Si es necesario para tu aplicación

var app = builder.Build();

// Configurar canalización de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // Configuraciones para producción
    //app.UseExceptionHandler("/Home/Error");
    //app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); // Middleware de autorización

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();