using ControleIaas.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleIaas.Domain.Interface.Commands
{
    public interface IGetInstanciasFiltroCommand
    {
        Task<List<Instancias>> GetInstancias();
    }
}
