using AutoMapper;
using BasketApp.Application.ApplicationUser;
using BasketApp.Application.DTOs;
using BasketApp.Application.GameExtensions.Commands.CreateGame;
using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.CommentExtensions.Command
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand>
    {

        private readonly ICommentRepository _commentRepository;

        private readonly IMapper _mapper;
        private readonly IUserContext _userContext;

        public CreateCommentCommandHandler(ICommentRepository repository, IMapper mapper, IUserContext userContext)
        {
            _commentRepository = repository;
            _mapper = mapper;
            _userContext = userContext;

        }

        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = _mapper.Map<Comment>(request);

            comment.CreatedById = _userContext.GetCurrentUser().Email;

            await _commentRepository.AddCommentAsync(comment);

            return Unit.Value;

        }
    }
}
