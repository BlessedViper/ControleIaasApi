using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasSoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string SO { get; set; }
    }

}
