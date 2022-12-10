using ControleIaas.Domain.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleIaas.Domain.Entities
{
    public class Maquinas : IEntityPai
    {
        public int Id { get; set; }

        [Required]
        public int IdAmbiente { get; set; }
        [Required]
        public int IdTipo { get; set; }
        [Required]
        public string SO { get; set; }
        [Required]
        public string IpPrivado { get; set; }
        [Required]
        public string NomeDns { get; set; }
        [Required]
        public int PortaRdp { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Senha { get; set; }
        public bool Deleted { get; set; }
        [JsonIgnore]
        public virtual Ambientes Ambiente { get; set; }
        [JsonIgnore]
        public virtual TipoServer Tipo { get; set; }
        [JsonIgnore]
        public virtual List<Instancias> Instancia { get; set; }


    }
}
