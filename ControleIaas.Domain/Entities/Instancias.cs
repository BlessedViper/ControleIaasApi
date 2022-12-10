using ControleIaas.Domain.Interface;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleIaas.Domain.Entities
{
    public class Instancias : IEntityPai
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo IdServer é obrigatório")]
        public int IdMaquina { get; set; }
        [Required]
        public string Instancia { get; set; }
        [Required]
        public string Banco { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Senha { get; set; }
        public bool Deleted { get; set; }
        [JsonIgnore]
        public virtual Maquinas Maquina { get; set; }
        [JsonIgnore]
        public virtual Clientes Cliente { get; set; }

    }
}
