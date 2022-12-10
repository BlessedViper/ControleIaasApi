using ControleIaas.Domain.Entities;

namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadPortasUtilizadasDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int PortaHttp { get; set; }
        public int PortaHttps { get; set; }
        public int PortaMySecurity { get; set; }
        public int PortaOnPremises { get; set; }
        public bool Deleted { get; set; }
        public Clientes Cliente { get; set; }


    }
}
