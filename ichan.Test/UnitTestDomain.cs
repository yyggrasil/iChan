using ichan.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace ichan.Test
{
    [TestClass]
    public sealed class UnitTestDomain
    {
        public void TestUsuario()
        {
            CategoriaDaComunidade usuario = new CategoriaDaComunidade(1, "kaueleivas0@gmail.com", "1234Kaue", "kaue", null);

            Debug.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "kaue");
            Assert.AreEqual(usuario.Senha, "1234Kaue");
            Assert.AreEqual(usuario.Descricao, null);
            Assert.AreEqual(usuario.Email, "kaueleivas0@gmail.com");
        }

        [TestMethod]
        public void TestAmizade()
        {
            CategoriaDaComunidade usuario1 = new CategoriaDaComunidade(1, "kaueleivas0@gmail.com", "1234Kaue", "kaue", null);
            CategoriaDaComunidade usuario2 = new CategoriaDaComunidade(2, "arroba@gmail.com", "4321", "nao sei", null);
            Amizade amizade = new Amizade(1, DateTime.Today, usuario1, usuario2);

            Debug.WriteLine(JsonSerializer.Serialize(amizade));

            Assert.AreEqual(amizade.DataInicio, DateTime.Today);
        }

        [TestMethod]
        public void TestCategoria()
        {
            Categoria categoria = new Categoria(1, "Opiniao", "opiniao sobre jogo");

            Debug.WriteLine(JsonSerializer.Serialize(categoria));

            Assert.AreEqual(categoria.Nome, "Opiniao");
            Assert.AreEqual(categoria.Descricao, "opiniao sobre jogo");
        }

        [TestMethod]
        public void TestCategoriaDaComunidade()
        {
            Categoria categoria = new Categoria();
            Comunidade comunidade = new Comunidade();
            CategoriaDaComunidade categoriaDaComunidade = new CategoriaDaComunidade(1, categoria, comunidade);
            
            Debug.WriteLine(JsonSerializer.Serialize(categoriaDaComunidade));

            Assert.IsNotNull(categoriaDaComunidade);
        }

        [TestMethod]
        public void TestComentario()
        {
            CategoriaDaComunidade usuario = new Usuario();
            Post post = new Post();
            Comentario comentario = new Comentario(1, "so um texto", DateTime.Today, usuario, post);

            Debug.WriteLine(JsonSerializer.Serialize(comentario));

            Assert.IsNotNull(comentario);
            Assert.AreEqual(comentario.Texto, "so um texto");
            Assert.AreEqual(comentario.DateComentario, DateTime.Today);
        }

        [TestMethod]
        public void TestComunidade()
        {
            Comunidade comunidade = new Comunidade(1, "brawhalla", "jogo de odio", DateTime.Today);

            Debug.WriteLine(JsonSerializer.Serialize(comunidade));

            Assert.IsNotNull(comunidade);
            Assert.AreEqual(comunidade.Nome, "brawhalla");
            Assert.AreEqual(comunidade.Descricao, "jogo de odio");
            Assert.AreEqual(comunidade.DataCriacao, DateTime.Today);
        }

        [TestMethod]
        public void TestParticipa()
        {
            CategoriaDaComunidade usuario = new Usuario();
            Comunidade comunidade = new Comunidade();
            Segue participa = new Segue(1, DateTime.Today, usuario, comunidade);

            Debug.WriteLine(JsonSerializer.Serialize(participa));

            Assert.IsNotNull(participa);
            Assert.AreEqual(participa.DataSeguida, DateTime.Today);
        }

        [TestMethod]
        public void TestPosts()
        {
            Comunidade comunidade = new Comunidade();
            CategoriaDaComunidade usuario = new Usuario();
            Post posts = new Post(1, "Jogo ruim", "jogo é pay to win", DateTime.Today,
                comunidade, usuario);

            Debug.WriteLine(JsonSerializer.Serialize(posts));

            Assert.AreEqual(posts.Titulo, "Jogo ruim");
            Assert.AreEqual(posts.Texto, "jogo é pay to win");
            Assert.AreEqual(posts.DataPost, DateTime.Today);

        }
    }
}
