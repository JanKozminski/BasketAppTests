using BasketApp.Domain.Entities;
using BasketApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.Services
{
    public class CoachService : ICoachService
    {
        private readonly ICoachRepository _coachRepository;

        public CoachService(ICoachRepository coachRepository)
        {
            _coachRepository = coachRepository;
        }

        public async Task<IEnumerable<CurrentCoaches>> GetAllCoachesAsync()
        {
            return await _coachRepository.GetAllCoachesAsync();
        }
    }
}
