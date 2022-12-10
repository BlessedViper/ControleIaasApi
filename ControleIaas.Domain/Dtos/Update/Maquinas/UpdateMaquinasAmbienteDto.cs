using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasAmbienteDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdAmbiente { get; set; }
    }
}
