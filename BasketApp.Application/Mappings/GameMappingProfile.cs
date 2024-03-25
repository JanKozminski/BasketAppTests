using AutoMapper;
using BasketApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.Mappings
{
	public class GameMappingProfile : Profile
	{
		public GameMappingProfile() {

			CreateMap<GameDto, Domain.Entities.Game>();


            CreateMap<Domain.Entities.Game, GameDto>();
        }

	}
}
