using BasketApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BasketApp.Infrastructure.Extensions;
using BasketApp.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddInfrastructure(builder.Configuration);


var app = builder.Build();

var scope = app.Services.CreateScope();

var stateSeeder = scope.ServiceProvider.GetRequiredService<StateSeeder>();

await stateSeeder.Seed();

var citySeeder = scope.ServiceProvider.GetRequiredService<CitySeeder>();

await citySeeder.Seed();

var divisionSeeder = scope.ServiceProvider.GetRequiredService<DivisionSeeder>();

await divisionSeeder.Seed();

var conferenceSeeder = scope.ServiceProvider.GetRequiredService<ConferenceSeeder>();

await conferenceSeeder.Seed();
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
