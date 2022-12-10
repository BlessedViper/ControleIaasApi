using System.Threading.Tasks;

namespace ControleIaas.Domain.Interface
{
    public interface IActiveObject
    {
        Task Active<T>(T obj) where T : class, IEntityPai;
        Task<T> GetActive<T>(int id) where T : class, IEntityPai;
    }
}
