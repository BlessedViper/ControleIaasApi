using ControleIaas.Domain.Entities;

namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadClientesDto
    {
        public int Id { get; set; }
        public int IdAmbiente { get; set; }
        public int IdInstancia { get; set; }
        public int IdVersao { get; set; }
        public string Nome { get; set; }
        public bool Deleted { get; set; }
        public Instancias Instancias { get; set; }
        public Ambientes Ambiente { get; set; }
        public VersaoContr Versao { get; set; }

    }
}
