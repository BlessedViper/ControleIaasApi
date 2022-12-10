using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasSenhaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
