using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Clientes
{
    public class UpdateClientesAmbienteDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdAmbiente { get; set; }
    }
}
