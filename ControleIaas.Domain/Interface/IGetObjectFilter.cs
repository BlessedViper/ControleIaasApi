using ControleIaas.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleIaas.Domain.Interface
{
    public interface IGetObjectFilter
    {
        public Task<List<T>> GetObj<T>() where T : class;
        public Task<List<Maquinas>> GetMaquinasAmbiente(int id);
        public Task<T> GetObjId<T>(int id) where T : class, IEntityPai;
    }
}
