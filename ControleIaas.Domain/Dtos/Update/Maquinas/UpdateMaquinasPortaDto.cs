using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasPortaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int PortaRdp { get; set; }
    }
}
