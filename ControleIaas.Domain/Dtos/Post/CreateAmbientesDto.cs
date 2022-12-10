using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Post
{
    public class CreateAmbientesDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Versao { get; set; }
    }
}
