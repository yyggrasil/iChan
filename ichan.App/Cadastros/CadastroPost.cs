using ichan.App.Base;
using ichan.App.Models;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;

namespace ichan.App.Cadastros
{
    public partial class CadastroPost : CadastroBase
    {
        private List<PostModel> posts;

        private IBaseService<Post> _postService;
        private IBaseService<Usuario> _usuarioService;
        private IBaseService<Comunidade> _comunidadeService;
        public CadastroPost(IBaseService<Post> postService,
                                IBaseService<Usuario> usuarioService,
                                IBaseService<Comunidade> comunidadeService)
        {
            _postService = postService;
            _usuarioService = usuarioService;
            _comunidadeService = comunidadeService;

            posts = new List<PostModel>();

            InitializeComponent();

            CarregaCombo();
            Novo();
        }

        private void PreencheObjeto(Post post)
        {
            post.Conteudo = txtConteudo.Text;
            post.Titulo = txtTitulo.Text;
            if (int.TryParse(cboComunidade.SelectedValue.ToString(), out var idComunidade))
            {
                var comunidade = _comunidadeService.GetById<Comunidade>(idComunidade);
                post.Comunidade = comunidade;
            }

            if (int.TryParse(cboUsuario.SelectedValue.ToString(), out var idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                post.Usuario = usuario;
            }
        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var post = _postService.GetById<Post>(id);
                        PreencheObjeto(post);
                        post = _postService.Update<Post, Post, PostValidator>(post);
                    }
                }
                else
                {
                    var post = new Post();
                    PreencheObjeto(post);
                    post = _postService.Add<Post, Post, PostValidator>(post);
                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Deletar(int id)
        {
            try
            {
                _postService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            posts = _postService.Get<PostModel>(false, new[] { "Usuario", "Comunidade" }).ToList();
            dataGridViewConsulta.DataSource = posts;
            dataGridViewConsulta.Columns["IdUsuario"]!.Visible = false;
            dataGridViewConsulta.Columns["IdComunidade"]!.Visible = false;
            dataGridViewConsulta.AutoResizeColumns();
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();

            var post = _postService.GetById<Post>(id, true);
            cboUsuario.SelectedValue = linha?.Cells["Usuario"].Value;
            cboComunidade.SelectedValue = linha?.Cells["Comunidade"].Value;

        }
        private void CarregaCombo()
        {
            cboComunidade.DataSource = _comunidadeService.Get<ComunidadeModel>().ToList();
            cboComunidade.ValueMember = "Id";
            cboComunidade.DisplayMember = "Nome";

            cboUsuario.DataSource = _comunidadeService.Get<UsuarioModel>().ToList();
            cboUsuario.ValueMember = "Id";
            cboUsuario.DisplayMember = "Nome";
        }
        protected override void Novo()
        {
            base.Novo();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
