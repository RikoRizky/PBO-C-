using GudangWebApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddViewOptions(options => {
        options.HtmlHelperOptions.ClientValidationEnabled = true;
    });

// Konfigurasi DbContext SQLite (Bab 9)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=gudang.db"));

var app = builder.Build();

// Inisialisasi Database dan Seed Data otomatis
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context.Database.EnsureCreated();
    if (!context.Barang.Any())
    {
        context.Barang.AddRange(
            new Barang { KodeBarang = "B111", NamaBarang = "Besi", JumlahStok = 90, Kategori = "Perkakas" },
            new Barang { KodeBarang = "B112", NamaBarang = "Besi rongsokan", JumlahStok = 2, Kategori = "Perkakas" }
        );
        context.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
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
