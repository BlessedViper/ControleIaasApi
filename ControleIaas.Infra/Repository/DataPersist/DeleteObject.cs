using ControleIaas.Infra.Context;
using ControleIaas.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ControleIaas.Infra.Repository.DataPersist
{
    public class DeleteObject : IDeleteObject
    {
        private readonly DataContext _context;

        public DeleteObject(DataContext context)
        {
            _context = context;
        }

        public void DeleteObj<T>(T obj)
            where T : class, IEntityPai
        {
            if (obj.Deleted == true)
                return;

            obj.Deleted = true;
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            _context.DeatchAllEntities();

        }

        public async Task<T> GetDelete<T>(int id) where T : class, IEntityPai
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
