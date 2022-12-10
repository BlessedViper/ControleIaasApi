using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.TipoServer
{
    public class UpdateTipoServerDescricaoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
