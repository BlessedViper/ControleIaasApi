using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Instancias
{
    public class UpdateInstanciasInstanciaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Instancia { get; set; }
    }
}
