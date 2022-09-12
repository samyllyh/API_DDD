using Entites.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestruture.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Message> Message { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        //string de conecção
        public string ObterStringConexao()
        {
            return "Data Source=DESKTOP-TRVTAH5\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        }

        //se não foi configurada a string de configuração
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }

        }

        //vai mapear os usuarios pela a chave de usuario
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
            base.OnModelCreating(builder);
        }
    }
}