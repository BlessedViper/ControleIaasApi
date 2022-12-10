using ControleIaas.Domain.Entities;

namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadInstanciasDto
    {
        public int Id { get; set; }
        public int IdMaquina { get; set; }
        public string Instancia { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool Deleted { get; set; }
        public Maquinas Maquina { get; set; }
        public Clientes Cliente { get; set; }

    }
}
