using BasketApp.Application.GameExtensions.Commands.CreateGame;
using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using MediatR;


namespace BasketApp.Application.GameExtensions.Queries.GetAllGames
{
    public class GetAllGamesQueryHandler : IRequestHandler<GetAllGamesQuery, IEnumerable<Game>>
    {
        private readonly IGameRepository _gameRepository;
        public GetAllGamesQueryHandler(IGameRepository gameRepository)
        {

            _gameRepository = gameRepository;
        }
        public async Task<IEnumerable<Game>> Handle(GetAllGamesQuery request, CancellationToken cancellationToken)
        {
            return await _gameRepository.GetAllGamesAsync();
        }
    }
}
