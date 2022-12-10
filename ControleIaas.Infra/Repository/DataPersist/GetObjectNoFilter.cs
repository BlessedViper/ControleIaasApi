using ControleIaas.Infra.Context;
using ControleIaas.Domain.Entities;
using ControleIaas.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleIaas.Infra.Repository.DataPersist
{
    public class GetObjectNoFilter : IGetObject
    {
        private readonly DataContext _context;
        public GetObjectNoFilter(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Maquinas>> GetMaquinasAmbiente(int id)
        {
            var result = await _context.Maquinas.Include(x => x.Ambiente.Nome).AsNoTracking().IgnoreQueryFilters().Where(x => x.IdAmbiente == id).ToListAsync();
            return result;
        }

        public async Task<List<T>> GetObj<T>() where T : class
        {
            var result = await _context.Set<T>().AsNoTracking().IgnoreQueryFilters().ToListAsync();
            return result;
        }
    }
}
