using ControleIaas.Infra.Context;
using ControleIaas.Domain.Entities;
using ControleIaas.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleIaas.Infra.Repository.DataPersist
{
    public class GetObject : IGetObjectFilter
    {
        private readonly DataContext _context;

        public GetObject(DataContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetObj<T>()
            where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<T> GetObjId<T>(int id)
            where T : class, IEntityPai
        {
            return await _context.Set<T>().IgnoreQueryFilters().FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<List<Maquinas>> GetMaquinasAmbiente(int id)
        {
            var maquinas = await _context.Maquinas
                .Include(x => x.Ambiente)
                .Where(x => x.IdAmbiente == id)
                .ToListAsync();
            return maquinas;
        }
    }
}
