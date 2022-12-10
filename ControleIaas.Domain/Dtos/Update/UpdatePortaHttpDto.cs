using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update
{
    public class UpdatePortaHttpDto
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public int PortaHttp { get; set; }
    }
}
