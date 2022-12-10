using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Clientes
{
    public class UpdateClientesInstanciaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdInstancia { get; set; }
    }
}
