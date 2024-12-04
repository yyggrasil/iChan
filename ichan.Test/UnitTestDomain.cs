using ichan.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace ichan.Test
{
    [TestClass]
    public sealed class UnitTestDomain
    {

        [TestMethod]
        public void TestAmizade()
        {
            Amizade amizade = new Amizade(1, DateTime.Today);

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
            CategoriaDaComunidade categoriaDaComunidade = new CategoriaDaComunidade(1);
            
            Debug.WriteLine(JsonSerializer.Serialize(categoriaDaComunidade));

            Assert.IsNotNull(categoriaDaComunidade);
        }

        [TestMethod]
        public void TestComentario()
        {
            Comentario comentario = new Comentario(1, "so um texto", DateTime.Today);

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
            Participa participa = new Participa(1, DateTime.Today);

            Debug.WriteLine(JsonSerializer.Serialize(participa));

            Assert.IsNotNull(participa);
            Assert.AreEqual(participa.DataSeguida, DateTime.Today);
        }

        [TestMethod]
        public void TestPosts()
        {
            Posts posts = new Posts(1, "Jogo ruim", "jogo é pay to win", DateTime.Today);

            Debug.WriteLine(JsonSerializer.Serialize(posts));

            Assert.AreEqual(posts.Titulo, "Jogo ruim");
            Assert.AreEqual(posts.Descricao, "jogo é pay to win");
            Assert.AreEqual(posts.DataPost, DateTime.Today);

        }

        [TestMethod]
        public void TestUsuario()
        {
            Usuario usuario = new Usuario(1, "kaueleivas0@gmail.com", "1234Kaue", "kaue", null);

            Debug.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "kaue");
            Assert.AreEqual(usuario.Senha, "1234Kaue");
            Assert.AreEqual(usuario.Descricao, null);
            Assert.AreEqual(usuario.Email, "kaueleivas0@gmail.com");
        }
    }
}
