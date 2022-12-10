using System.Threading.Tasks;

namespace ControleIaas.Domain.Interface
{
    public interface IPostObject
    {
        Task<T> SaveObject<T>(T obj) where T : class;
    }
}
