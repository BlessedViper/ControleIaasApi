using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Interface
{
    public interface IEntityPai
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public bool Deleted { get; set; }
    }
}
