using ControleIaas.Domain.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleIaas.Domain.Entities
{
    public class VersaoContr : IEntityPai
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Versao é obrigatório")]
        public string Versao { get; set; }
        public bool Deleted { get; set; }
        [JsonIgnore]
        public virtual List<Clientes> Clientes { get; set; }
    }
}
