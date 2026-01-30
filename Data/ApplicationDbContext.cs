using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Livraria.Models;

namespace Livraria.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Livraria.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Livraria.Models.Autor> Autor { get; set; } = default!;
    }
}
