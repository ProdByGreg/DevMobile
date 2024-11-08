namespace Personagem.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Fantasia { get; set; } = string.Empty;
        public string Local { get; set; } = string.Empty;
    }
}
