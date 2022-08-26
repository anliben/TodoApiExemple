
using Microsoft.EntityFrameworkCore;

namespace TodoApi.model.Clientes
{
    public class ClientesContext : DbContext
    {
        public ClientesContext(DbContextOptions<ClientesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ClientesModel> ClientesModels { get; set; }
    }
}
