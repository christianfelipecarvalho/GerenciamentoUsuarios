using Microsoft.EntityFrameworkCore;
using PaginaLogin.Models;

namespace PaginaLogin.Data
{
    public class BancoContent : DbContext
    {
        public BancoContent(DbContextOptions<BancoContent> options) : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
