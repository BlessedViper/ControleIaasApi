using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Post
{
    public class CreatePortasUtilizadasDto
    {
        [Required]
        public int IdCliente { get; set; }
        public int PortaHTTP { get; set; }
        public int PortaHTTPS { get; set; }
        public int PortaMySecurity { get; set; }
        public int PortaOnPremises { get; set; }
    }
}
