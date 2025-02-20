using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using ProjectWebMVC.Data;
using ProjectWebMVC.Services;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjectWebMVCContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("ProjectWebMVCContext"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ProjectWebMVCContext"))
    ));

builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();
//services.AddScoped<SeedingService>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();



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
