using Licenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Repository
{
    public interface IDetaliiRepository
    {
        Task Create(Detalii detalii);

        Task Edit(Detalii detalii);

        Task<Detalii> GetSingleDetalii(int id);

        Task Delete(Detalii detalii);

        Task<List<Detalii>> GetAllDetalii();

        Task<List<Detalii>> GetDetaliiByUserId(string userId);

        Task Save();
    }
}
