using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketApp.Domain.Entities;

namespace BasketApp.Domain.Interfaces
{
    public interface ICoachRepository
    {
        Task<IEnumerable<CurrentCoaches>> GetAllCoachesAsync();
    }
}
