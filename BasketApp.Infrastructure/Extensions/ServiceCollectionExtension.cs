using BasketApp.Domain.Interfaces;
using BasketApp.Infrastructure.Persistence;
using BasketApp.Infrastructure.Repositories;
using BasketApp.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<BasketAppDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("BasketApp")));

            services.AddScoped<StateSeeder>();
            services.AddScoped<ConferenceSeeder>();
            services.AddScoped<CitySeeder>();
            services.AddScoped<DivisionSeeder>();
            services.AddScoped<TeamSeeder>();
            services.AddScoped<CoachSeeder>();
            services.AddScoped<PlayerSeeder>();
            services.AddScoped<HistoricalTeamSeeder>();
            services.AddScoped<HistoricalPlayerSeeder>();


            services.AddScoped<IHistoricalTeamRepository, HistoricalTeamRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<ICoachRepository, CoachRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IGameRepository, GameRepository>();

        }
    }
}
