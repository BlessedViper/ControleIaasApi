using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Post
{
    public class CreateMaquinasDto
    {
        [Required(ErrorMessage = "Campo IdAmbiente é obrigatório")]
        public int IdAmbiente { get; set; }
        [Required(ErrorMessage = "Campo IdTipo é obrigatório")]
        public int IdTipo { get; set; }
        [Required(ErrorMessage = "Campo SoAmbiente é obrigatório")]
        public string SO { get; set; }
        [Required(ErrorMessage = "Campo IpPrivado é obrigatório")]
        public string IpPrivado { get; set; }
        [Required(ErrorMessage = "Campo NomeDns é obrigatório")]
        public string NomeDns { get; set; }
        [Required(ErrorMessage = "Campo PortaRdp é obrigatório")]
        public int PortaRdp { get; set; }
        [Required(ErrorMessage = "Campo User é obrigatório")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Campo Pass é obrigatório")]
        public string Senha { get; set; }
    }
}
