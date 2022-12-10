using System.ComponentModel.DataAnnotations;


namespace ControleIaas.Domain.Dtos.Post
{
    public class BackupDto
    {
        [Required]
        public int IdInstancia { get; set; }
    }
}
