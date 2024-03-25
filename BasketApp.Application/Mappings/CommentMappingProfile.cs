using AutoMapper;
using BasketApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.Mappings
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile() {
            CreateMap<CommentDto, Domain.Entities.Comment>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now));
        
        }
    }
}
