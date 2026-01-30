namespace Livraria.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int LivroId { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        // Navegação
        public Cliente Cliente { get; set; }
        public Livro Livro { get; set; }
    }
}
