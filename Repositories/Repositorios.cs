using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<FilmeLocacao> FilmesLocacoes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            //=> options.UseMySql("Server=localhost;User Id=root;Database=blockbuster");
            => options.UseMySql($"Server=db-app.cjfysft933dn.us-east-1.rds.amazonaws.com;User Id={Dados.Login};Password={Dados.Senha};Database=blockbuster");
            //=> options.UseMySql("server=localhost;database=library;user=mysqlschema;password=mypassword");
        }
}