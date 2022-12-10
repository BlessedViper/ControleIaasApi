using System.Threading.Tasks;

namespace ControleIaas.Domain.Interface
{
    public interface IUpdateObject
    {
        public void Update<T>(T obj) where T : class;
        public Task<T> TesteUpdate<T>(int id) where T : class, IEntityPai;
    }
}
