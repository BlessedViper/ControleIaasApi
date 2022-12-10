using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.TipoServer
{
    public class UpdateTipoServerServicosDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Servicos { get; set; }
    }
}
