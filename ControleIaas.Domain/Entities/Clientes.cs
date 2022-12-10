using ControleIaas.Domain.Interface;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleIaas.Domain.Entities
{
    public class Clientes : IEntityPai
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int IdAmbiente { get; set; }
        [Required]
        public int IdInstancia { get; set; }
        [Required]
        public int IdVersao { get; set; }
        public bool Deleted { get; set; }
        [JsonIgnore]
        public virtual Instancias Instancia { get; set; }
        [JsonIgnore]
        public virtual Ambientes Ambiente { get; set; }
        [JsonIgnore]
        public virtual VersaoContr Versao { get; set; }

    }
}
