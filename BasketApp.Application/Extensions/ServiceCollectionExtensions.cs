using BasketApp.Application.ApplicationUser;
using BasketApp.Application.Mappings;
using BasketApp.Application.Services;
using BasketApp.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketApp.Application.GameExtensions.Commands.CreateGame;
using BasketApp.Application.CommentExtensions.Command;

namespace BasketApp.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IUserContext, UserContext>();

            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ICoachService, CoachService>();
            services.AddMediatR(typeof(CreateGameCommand));
            services.AddMediatR(typeof(CreateCommentCommand));

            services.AddAutoMapper(typeof(GameMappingProfile));
            services.AddAutoMapper(typeof(CommentMappingProfile));
        }

    }
}
