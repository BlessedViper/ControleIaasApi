using ControleIaas.Domain.Entities;
using System.Collections.Generic;

namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadAmbientesDto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Versao { get; set; }
        public bool Deleted { get; set; }
        public List<Clientes> Clientes { get; set; }
        public List<Maquinas> Maquinas { get; set; }
    }
}
