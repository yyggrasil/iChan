using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ichan.Test
{
    [TestClass]
    public sealed class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            //public DbSet<Amizade> Amizades { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<CategoriaDaComunidade> CategoriasDasComunidades { get; set; }
            public DbSet<Comentario> Comentarios { get; set; }
            public DbSet<Comunidade> Comunidades { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Segue> Seguidores { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "ichanTestRepository";
                var username = "root";
                var password = "admin";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertUsuarios()
        {
            using (var db = new MyDbContext())
            {
                var usuario = new Usuario
                {
                    Email = "kaueleivas0@gmail.com",
                    Senha = "123Kaue",
                    Nome = "kaue leivas",
                    Descricao = "dono do forum"
                };
                db.Usuarios.Add(usuario);

                usuario = new Usuario
                {
                    Email = "aroba@gmail.com",
                    Senha = "123",
                    Nome = "tudo certo",
                    Descricao = "escravo"
                };
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }
        [TestMethod]
        public void TestInsertComunidade()
        {
            using (var db = new MyDbContext())
            {
                var comunidade = new Comunidade
                {
                    Nome = "RPG Para nerds",
                    Descricao = "o maximo de diversao para nerds",
                    DataCriacao = DateTime.Today
                };
                db.Comunidades.Add(comunidade);

                comunidade = new Comunidade
                {
                    Nome = "sofredores",
                    Descricao = "sofredores de souls-like",
                    DataCriacao = DateTime.Today
                };
                db.Comunidades.Add(comunidade);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestInsertCategoria()
        {
            using (var db = new MyDbContext())
            {
                var categoria = new Categoria
                {
                    Nome = "RPG",
                    Descricao = "Jogos de faz de conta"
                };
                db.Categorias.Add(categoria);

                categoria = new Categoria
                {
                    Nome = "Souls-like",
                    Descricao = "Stress Pago"
                };
                db.Categorias.Add(categoria);
                db.SaveChanges();
            }
        }
        /*
        [TestMethod]
        public void TestInsertAmizade()
        {
            using (var db = new MyDbContext())
            {
                var usuario1 = db.Usuarios.FirstOrDefault(u => u.Id == 1);
                var usuario2 = db.Usuarios.FirstOrDefault(u => u.Id == 2);

                var amizade = new Amizade
                {
                    DataInicio = DateTime.Today,
                    Usuario1 = usuario1,
                    Usuario2 = usuario2
                };
                db.Amizades.Add(amizade);
                db.SaveChanges();
            }
        }
        */
        [TestMethod]
        public void TestInsertCategoriasDasComunidades()
        {
            using (var db = new MyDbContext())
            {
                var categoria = db.Categorias.FirstOrDefault(u => u.Id == 1);
                var comunidade = db.Comunidades.FirstOrDefault(u => u.Id == 1);

                var categoriaDaComunidade = new CategoriaDaComunidade
                {
                    Categoria = categoria,
                    Comunidade = comunidade
                };
                db.CategoriasDasComunidades.Add(categoriaDaComunidade);

                categoria = db.Categorias.FirstOrDefault(u => u.Id == 2);
                comunidade = db.Comunidades.FirstOrDefault(u => u.Id == 2);

                categoriaDaComunidade = new CategoriaDaComunidade
                {
                    Categoria = categoria,
                    Comunidade = comunidade
                };
                db.CategoriasDasComunidades.Add(categoriaDaComunidade);

                db.SaveChanges();
            }
        }
        [TestMethod]
        public void TestInsertPosts()
        {
            using (var db = new MyDbContext())
            {
                var usuario = db.Usuarios.FirstOrDefault(u => u.Id == 1);
                var comunidade = db.Comunidades.FirstOrDefault(u => u.Id == 1);

                var post = new Post
                {
                    Titulo = "Zerei Dark Souls",
                    Descricao = "O Jogo é muito desafiante mas trouxe diversao no mundo sombrio, LOUVE O SOL!",
                    DataPost = DateTime.Today,
                    Usuario = usuario,
                    Comunidade = comunidade
                };
                db.Posts.Add(post);

                usuario = db.Usuarios.FirstOrDefault(u => u.Id == 1);
                comunidade = db.Comunidades.FirstOrDefault(u => u.Id == 2);

                post = new Post
                {
                    Titulo = "Finalmente aconteceu",
                    Descricao = "finalmente cheguei na cena do urso do baldurs gate, me surpreendeu e fiquei em choq",
                    DataPost = DateTime.Today,
                    Usuario = usuario,
                    Comunidade = comunidade
                };
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestInsertSeguidores()
        {
            using (var db = new MyDbContext())
            {
                var usuario = db.Usuarios.FirstOrDefault(u => u.Id == 1);
                var comunidade = db.Comunidades.FirstOrDefault(u => u.Id == 1);

                var segue = new Segue
                {
                    DataSeguida = DateTime.Today,
                    Usuario = usuario,
                    Comunidade = comunidade
                };
                db.Seguidores.Add(segue);

                usuario = db.Usuarios.FirstOrDefault(u => u.Id == 2);
                comunidade = db.Comunidades.FirstOrDefault(u => u.Id == 1);

                segue = new Segue
                {
                    DataSeguida = DateTime.Today,
                    Usuario = usuario,
                    Comunidade = comunidade
                };
                db.Seguidores.Add(segue);

                usuario = db.Usuarios.FirstOrDefault(u => u.Id == 1);
                comunidade = db.Comunidades.FirstOrDefault(u => u.Id == 2);

                segue = new Segue
                {
                    DataSeguida = DateTime.Today,
                    Usuario = usuario,
                    Comunidade = comunidade
                };
                db.Seguidores.Add(segue);

                db.SaveChanges();
            }
        }
        /*
        [TestMethod]
        public void TestInsertComentario()
        {
            using (var db = new MyDbContext())
            {
                var usuario = db.Usuarios.FirstOrDefault(u => u.Id == 1);
                Post post = db.Posts.FirstOrDefault(p => p.Id == 1);

                var comentario = new Comentario
                {
                    Texto = "já zerei muito facil",
                    DateComentario = DateTime.Today,
                    Usuario = usuario,
                    Post = post
                };
                db.Comentarios.Add(comentario);
                post.Comentarios.Add(comentario);
                
                usuario = db.Usuarios.FirstOrDefault(u => u.Id == 2);
                post = db.Posts.FirstOrDefault(p => p.Id == 2);

                comentario = new Comentario
                {
                    Texto = "já zerei muito facil",
                    DateComentario = DateTime.Today,
                    Usuario = usuario,
                    Post = post
                };
                db.Comentarios.Add(comentario);
                post.Comentarios.Add(comentario);

                db.SaveChanges();
            }

        }
        */
    }
}
