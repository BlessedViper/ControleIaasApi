namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadVersaoContrDto
    {
        public int Id { get; set; }
        public string Versao { get; set; }
        public bool Deleted { get; set; }
        public object Clientes { get; set; }
    }
}
