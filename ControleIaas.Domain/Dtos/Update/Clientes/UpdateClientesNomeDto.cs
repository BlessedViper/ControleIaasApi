using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Clientes
{
    public class UpdateClientesNomeDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
