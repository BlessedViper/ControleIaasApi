using ControleIaas.Infra.Context;
using ControleIaas.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ControleIaas.Infra.Repository.DataPersist
{
    public class UpdateObject : IUpdateObject
    {
        private readonly DataContext _context;
        public UpdateObject(DataContext context)
        {
            _context = context;
        }
        public void Update<T>(T obj)
            where T : class
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            _context.DeatchAllEntities();
        }
        public async Task<T> TesteUpdate<T>(int id)
            where T : class, IEntityPai
        {
            return await _context.Set<T>().AsNoTracking().IgnoreQueryFilters().FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}
