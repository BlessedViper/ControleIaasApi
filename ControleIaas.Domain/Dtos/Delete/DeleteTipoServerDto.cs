using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Delete
{
    public class DeleteTipoServerDto
    {
        [Required]
        public bool Status { get; set; }
        [Required]
        public int Id { get; set; }
    }
}
