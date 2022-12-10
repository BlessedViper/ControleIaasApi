using ControleIaas.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleIaas.Domain.Interface.Commands
{
    public interface IGetInstanciasCommand
    {
        Task<List<Instancias>> GetInstancias();
    }
}
