using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Instancias
{
    public class UpdateInstanciasSenhaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
