using ControleIaas.Domain.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleIaas.Domain.Entities
{
    public class TipoServer : IEntityPai
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Descricao é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Servicos é obrigatório")]
        public string Servicos { get; set; }
        public bool Deleted { get; set; }
        [JsonIgnore]
        public virtual List<Maquinas> Maquinas { get; set; }
    }
}
