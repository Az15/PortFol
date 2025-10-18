using Microsoft.EntityFrameworkCore;
using PortFol.DataAccess;
using Microsoft.EntityFrameworkCore.SqlServer; // Agrega esta línea

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Obtener la cadena de conexión del archivo appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 1. Registro del DbContext con Inyección de Dependencias
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // Usamos el proveedor SQL Server y la cadena de conexión.
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //Cae el error si pincha si no esta en DESARROLLO
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //Aca es donde se define el controlador y la accion por defecto.
    //Osea si no le pasas nada en la URL, va a ir a Home/Index
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

