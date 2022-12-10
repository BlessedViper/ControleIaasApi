using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Post
{
    public class CreateInstanciasDto
    {

        [Required(ErrorMessage = "Campo IdMaquina é obrigatório")]
        public int IdMaquina { get; set; }
        [Required(ErrorMessage = "Campo Instancia é obrigatório")]
        public string Instancia { get; set; }
        [Required]
        public string Banco { get; set; }

        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
