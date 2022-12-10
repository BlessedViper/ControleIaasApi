using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Instancias
{
    public class UpdateInstanciasBancoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Banco { get; set; }
    }
}
