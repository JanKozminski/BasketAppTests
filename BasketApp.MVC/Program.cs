using BasketApp.Infrastructure.Extensions;
using BasketApp.Application.Extensions;
using BasketApp.Infrastructure.Seeders;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddApplication();






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

var teamSeeder = scope.ServiceProvider.GetRequiredService<TeamSeeder>();

await teamSeeder.Seed();

var coachSeeder = scope.ServiceProvider.GetRequiredService<CoachSeeder>();

await coachSeeder.Seed();

var playerSeeder = scope.ServiceProvider.GetRequiredService<PlayerSeeder>();

await playerSeeder.Seed();

var historicalTeamSeeder = scope.ServiceProvider.GetRequiredService<HistoricalTeamSeeder>();

await historicalTeamSeeder.Seed();

var historicalPlayerSeeder = scope.ServiceProvider.GetRequiredService<HistoricalPlayerSeeder>();

await historicalPlayerSeeder.Seed();



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

app.MapRazorPages();

app.Run();
