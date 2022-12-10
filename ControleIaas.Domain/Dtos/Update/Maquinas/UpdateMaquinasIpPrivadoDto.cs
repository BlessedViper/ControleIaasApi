using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasIpPrivadoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string IpPrivado { get; set; }
    }
}
