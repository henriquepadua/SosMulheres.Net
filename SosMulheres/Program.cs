using Microsoft.EntityFrameworkCore;
using SosMulheres.Config;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddEntityFrameworkNpgsql()
//    .AddDbContext<SosMulheresContext>(options =>
//    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=sosmulheres;User Id=ti2cc;Password=ti2cc;"));

builder.Services.AddDbContext<SosMulheresContext>(options =>
options.UseNpgsql(
builder.Configuration.GetConnectionString("DefaultConnection")
));


var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();