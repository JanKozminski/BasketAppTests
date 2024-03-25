using AutoMapper;
using BasketApp.Application.GameExtensions.Commands.CreateGame;
using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.CommentExtensions.Query
{
    public class GetCommentsByGameQueryHandler : IRequestHandler<GetCommentsByGameQuery, IEnumerable<Comment>>
    {


        private readonly ICommentRepository _commentRepository;


        public GetCommentsByGameQueryHandler(ICommentRepository repository)
        {
            _commentRepository = repository; ;

        }

        public async Task<IEnumerable<Comment>> Handle(GetCommentsByGameQuery request, CancellationToken cancellationToken)
        {
            return await _commentRepository.GetCommentsByGameIdAsync(request.GameId); 
        }

    }
}
