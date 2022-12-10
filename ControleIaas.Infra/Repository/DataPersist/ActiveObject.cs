using ControleIaas.Domain.Interface;
using ControleIaas.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ControleIaas.Infra.Repository.DataPersist
{
    public class ActiveObject : IActiveObject
    {
        private readonly DataContext _context;
        public ActiveObject(DataContext context)
        {
            _context = context;
        }
        public async Task Active<T>(T obj)
            where T : class, IEntityPai
        {
            if (obj.Deleted == false)
                return;
            obj.Deleted = false;
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return;
        }

        public Task<T> GetActive<T>(int id)
            where T : class, IEntityPai
        {
            return _context.Set<T>().IgnoreQueryFilters().FirstOrDefaultAsync(X => X.Id == id);
        }
    }
}
