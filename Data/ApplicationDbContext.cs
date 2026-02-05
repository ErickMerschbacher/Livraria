using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Livraria.Models;

namespace Livraria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Emprestimo> Emprestimo { get; set; } = default!;
        public DbSet<Livro> Livro { get; set; } = default!;

        public DbSet<Autor> Autor { get; set; } = default!;
        public DbSet<Cliente> Cliente { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Additional configuration if needed
            builder.Entity<Livro>().ToTable("Livros");
            builder.Entity<Emprestimo>().ToTable("Emprestimos");
            builder.Entity<Autor>().ToTable("Autores");
            builder.Entity<Cliente>().ToTable("Clientes");

        }
    }
}
