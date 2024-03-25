using AutoMapper;
using BasketApp.Application.DTOs;
using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.GameExtensions.Commands.CreateGame
{
    public class CreateGameCommandHandler : IRequestHandler<CreateGameCommand>
    {
        private readonly IGameRepository _gameRepository;

        private readonly IMapper _mapper;

        public CreateGameCommandHandler(IGameRepository repository, IMapper mapper ) {
            _gameRepository = repository;
            _mapper = mapper;
        
        }

        public async Task<Unit> Handle(CreateGameCommand request, CancellationToken cancellationToken) {

            var game = _mapper.Map<Game>(request);

            await _gameRepository.Create(game);

            return Unit.Value;
        }

    }
}
