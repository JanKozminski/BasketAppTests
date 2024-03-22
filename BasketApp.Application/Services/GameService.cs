using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;

namespace BasketApp.Application.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        public GameService(IGameRepository gameRepository) {

            _gameRepository = gameRepository;
        
        }

        public async Task Create(Domain.Entities.Game game)
        {
           await _gameRepository.Create(game);
        }

        public async Task<IEnumerable<Game>> GetAllGamesAsync()
        {
            return await _gameRepository.GetAllGamesAsync();
        }
    }
}
