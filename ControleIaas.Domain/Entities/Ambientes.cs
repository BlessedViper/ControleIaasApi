using ControleIaas.Domain.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleIaas.Domain.Entities
{
    public class Ambientes : IEntityPai
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }
        public string Versao { get; set; }
        public bool Deleted { get; set; }
        [JsonIgnore]
        public virtual List<Clientes> Clientes { get; set; }
        [JsonIgnore]
        public virtual List<Maquinas> Maquinas { get; set; }
    }
}
