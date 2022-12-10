using ControleIaas.Domain.Entities;

namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadMaquinasDto
    {
        public int Id { get; set; }

        public int IdAmbiente { get; set; }
        public int IdTipo { get; set; }
        public string SO { get; set; }
        public string IpPrivado { get; set; }
        public string NomeDns { get; set; }
        public int PortaRdp { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool Deleted { get; set; }
        public Ambientes Ambiente { get; set; }
        public object Tipo { get; set; }
        public object Instancia { get; set; }


    }
}
