using Microsoft.EntityFrameworkCore;
using BolaoBrasileirao.Data; // ajuste o namespace se necessário

var builder = WebApplication.CreateBuilder(args);

// 🔹 REGISTRO DE SERVICES (vem antes do Build)

// MVC
builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// 🔹 PIPELINE HTTP (depois do Build)

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
