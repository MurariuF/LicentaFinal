using Licenta.Data;
using Licenta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Repository
{
    public class DetaliiRepository : IDetaliiRepository
    {
        private ApplicationDbContext _context;

        public DetaliiRepository(ApplicationDbContext context)
        {

            _context = context;
        }

        public async Task Create(Detalii detalii)
        {
            float inaltimea = detalii.Inaltimea;
            var greutate = detalii.Greutate;
            inaltimea = inaltimea / 100f;
            string rezultat2;
            var rezultat1 = greutate / (inaltimea * inaltimea);
            if (rezultat1 < 18.49)
                rezultat2 = "Subponderal";
            else
                if (rezultat1 > 18.50 && rezultat1 < 24.99)
                rezultat2 = "Greutate normala";
            else
                if (rezultat1 > 25 && rezultat1 < 29.99)
                rezultat2 = "Supraponderal";
            else
                if (rezultat1 > 30 && rezultat1 < 34.99)
                rezultat2 = "Obezitate(grad I)";
            else
                if (rezultat1 > 35 && rezultat1 < 39.99)
                rezultat2 = "Obezitate(grad II)";
            else
                rezultat2 = "Obezitate morbida";
            detalii.Rezultat1 = rezultat1;
            detalii.Rezultat2 = rezultat2;
            await _context.Detaliis.AddAsync(detalii);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Detalii detalii)
        {
            _context.Detaliis.Remove(detalii);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Detalii detalii)
        {
            float inaltimea = detalii.Inaltimea;
            var greutate = detalii.Greutate;
            inaltimea = inaltimea / 100f;
            string rezultat2;                        
            var rezultat1 = greutate / (inaltimea * inaltimea);
            if (rezultat1 < 18.49)
                rezultat2 = "Subponderal";
            else
                if (rezultat1 > 18.50 && rezultat1 < 24.99)
                rezultat2 = "Greutate normala";
            else
                if (rezultat1 > 25 && rezultat1 < 29.99)
                rezultat2 = "Supraponderal";
            else
                if (rezultat1 > 30 && rezultat1 < 34.99)
                rezultat2 = "Obezitate(grad I)";
            else
                if (rezultat1 > 35 && rezultat1 < 39.99)
                rezultat2 = "Obezitate(grad II)";
            else
                rezultat2 = "Obezitate morbida";
            detalii.Rezultat1 = rezultat1;
            detalii.Rezultat2 = rezultat2;
            _context.Detaliis.Update(detalii);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Detalii>>GetAllDetalii()
        {
            return await _context.Detaliis.ToListAsync();
        }

        public async Task<List<Detalii>> GetDetaliiByUserId(string userId)
        {
            return await _context.Detaliis.Where(d => d.UserId.Equals(userId)).ToListAsync();
        }

        public async Task<Detalii> GetSingleDetalii(int id)
        {
            var detalii = await _context.Detaliis.FirstOrDefaultAsync(p => p.Id == id);
            return detalii;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
