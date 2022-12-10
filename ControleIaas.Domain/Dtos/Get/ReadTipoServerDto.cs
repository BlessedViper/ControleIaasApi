using ControleIaas.Domain.Entities;
using System.Collections.Generic;

namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadTipoServerDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Servicos { get; set; }
        public bool Deleted { get; set; }
        public List<Maquinas> Maquinas { get; set; }
    }
}

