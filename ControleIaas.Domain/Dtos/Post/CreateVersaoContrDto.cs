using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Post
{
    public class CreateVersaoContrDto
    {
        [Required]
        public string Versao { get; set; }
    }
}
