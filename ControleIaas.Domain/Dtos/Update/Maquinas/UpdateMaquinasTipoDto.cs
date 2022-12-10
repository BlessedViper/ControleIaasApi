using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasTipoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdTipo { get; set; }
    }
}
