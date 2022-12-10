using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Post
{
    public class CreateTipoServerDto
    {
        [Required(ErrorMessage = "Campo Descricao é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Servicos é obrigatório")]
        public string Servicos { get; set; }
    }
}
