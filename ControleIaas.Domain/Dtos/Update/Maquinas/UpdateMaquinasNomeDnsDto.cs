using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Maquinas
{
    public class UpdateMaquinasNomeDnsDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string NomeDns { get; set; }
    }
}
