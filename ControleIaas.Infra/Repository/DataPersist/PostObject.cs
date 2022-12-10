using ControleIaas.Infra.Context;
using ControleIaas.Domain.Interface;
using System.Threading.Tasks;

namespace ControleIaas.Infra.Repository.DataPersist
{
    public class PostObject : IPostObject
    {
        private readonly DataContext _context;
        public PostObject(DataContext context)
        {
            _context = context;
        }
        public async Task<T> SaveObject<T>(T obj)
            where T : class
        {
            await _context.AddAsync(obj);
            _context.SaveChanges();
            _context.DeatchAllEntities();
            return obj;
        }
    }
}
