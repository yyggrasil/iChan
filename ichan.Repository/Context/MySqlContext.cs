using ichan.Domain.Entities;
using ichan.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ichan.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) 
            : base(options)
        {
            Database.EnsureCreated();        
        }
        //public DbSet<Amizade> Amizades { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaDaComunidade> CategoriaDaComunidades { get; set; }
        public DbSet<Comentario> Comentarios{ get; set; }
        public DbSet<Comunidade> Comunidades{ get; set; }
        public DbSet<Segue> Seguidas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Categoria>(new CategoriaMap().Configure);
            //modelBuilder.Entity<Amizade>(new AmizadeMap().Configure);
            modelBuilder.Entity<CategoriaDaComunidade>(new CategoriaDaComunidadeMap().Configure);
            modelBuilder.Entity<Comentario>(new ComentarioMap().Configure);
            modelBuilder.Entity<Comunidade>(new ComunidadeMap().Configure);
            modelBuilder.Entity<Segue>(new SegueMap().Configure);
            modelBuilder.Entity<Post>(new PostMap().Configure);
        }
    }
}
