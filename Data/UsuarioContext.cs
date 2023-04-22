using API_C_.Models;
using Microsoft.EntityFrameworkCore;

namespace API_C_.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }


        public DbSet<Usuario> Usuarios { get; set; }
    }
}