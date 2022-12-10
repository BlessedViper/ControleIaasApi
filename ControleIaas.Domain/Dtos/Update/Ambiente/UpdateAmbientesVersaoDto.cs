using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Ambiente
{
    public class UpdateAmbientesVersaoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Versao { get; set; }
    }
}
