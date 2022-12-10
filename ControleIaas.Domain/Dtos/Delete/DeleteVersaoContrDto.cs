using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Delete
{
    public class DeleteVersaoContrDto
    {
        [Required]
        public bool Status { get; set; }
        [Required]
        public int Id { get; set; }
    }
}
