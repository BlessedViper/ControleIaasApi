namespace ControleIaas.Domain.Dtos.Post
{
    public class CreateClientesDto
    {
        public string Nome { get; set; }
        public int IdAmbiente { get; set; }
        public int IdInstancia { get; set; }
        public int IdVersao { get; set; }
    }
}
