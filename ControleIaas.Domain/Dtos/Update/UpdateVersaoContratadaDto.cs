using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update
{
    public class UpdateVersaoContratadaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Versao { get; set; }
    }
}
