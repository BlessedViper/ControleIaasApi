using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Instancias
{
    public class UpdateInstanciasMaquinasDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdMaquina { get; set; }
    }
}
