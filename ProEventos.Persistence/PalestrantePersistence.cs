using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence
{
    internal class PalestrantePersistence : IPalestrantePersist
    {
        private readonly ProEventosContext _context;
        public PalestrantePersistence(ProEventosContext context)
        {
            _context = context;
        }
        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                            .Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos)
                             .ThenInclude(e => e.Evento);
            }

            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos)
                             .ThenInclude(e => e.Evento);
            }

            query = query.OrderBy(e => e.Id).Where(e => e.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                            .Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos)
                             .ThenInclude(e => e.Evento);
            }

            query = query.Where(e => e.Id == palestranteId);

            return await query.FirstOrDefaultAsync();
        }

    }
}
