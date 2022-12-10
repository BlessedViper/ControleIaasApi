using ControleIaas.Infra.Context;
using ControleIaas.Domain.Entities;
using ControleIaas.Domain.Interface.Commands;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleIaas.Infra.Repository.commands
{
    public class GetInstanciasFiltroCommand : IGetInstanciasFiltroCommand
    {
        private readonly DataContext _context;
        public List<Instancias> inst = new();
        public GetInstanciasFiltroCommand(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Instancias>> GetInstancias()
        {
            var instancias = await _context.Instancias.ToListAsync();

            foreach (var item in instancias)
            {
                item.Senha = Shared.Crip.Criptografia.Descriptografar(item.Senha);
                inst.Add(item);
            }
            return inst;
        }
    }
}
