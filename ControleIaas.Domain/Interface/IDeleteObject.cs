using System.Threading.Tasks;

namespace ControleIaas.Domain.Interface
{
    public interface IDeleteObject
    {
        void DeleteObj<T>(T obj) where T : class, IEntityPai;
        Task<T> GetDelete<T>(int id) where T : class, IEntityPai;
    }
}
