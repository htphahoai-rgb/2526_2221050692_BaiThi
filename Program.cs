using Microsoft.EntityFrameworkCore;
using _2526_2221050692_BaiThi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<VuVanCuongDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TenSinhVienDb")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<VuVanCuongDbContext>();
    db.Database.EnsureCreated();

    if (!db.LopHocs.Any())
    {
        db.LopHocs.AddRange(
            new _2526_2221050692_BaiThi.Models.LopHoc { MaLop = "LH001", TenLop = "Toán 10A" },
            new _2526_2221050692_BaiThi.Models.LopHoc { MaLop = "LH002", TenLop = "Vật lý 10B" },
            new _2526_2221050692_BaiThi.Models.LopHoc { MaLop = "LH003", TenLop = "Hóa học 10C" }
        );
        db.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
