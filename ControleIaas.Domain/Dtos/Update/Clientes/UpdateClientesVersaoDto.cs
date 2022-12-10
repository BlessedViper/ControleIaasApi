using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Clientes
{
    public class UpdateClientesVersaoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdVersao { get; set; }
    }
}
