using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasUsuarioDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Usuario { get; set; }
    }
}
