using ichan.App.Base;
using ichan.App.Models;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;

namespace ichan.App.Cadastros
{
    public partial class CadastroComentario : CadastroBase
    {
        private List<ComentarioModel> comentarios;

        private readonly IBaseService<Comentario> _comentarioService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Post> _postService;
        public CadastroComentario(  IBaseService<Comentario> comentarioService,
                                    IBaseService<Usuario> usuarioService,
                                    IBaseService<Post> postService)
        {
            _comentarioService = comentarioService;
            _postService = postService;
            _usuarioService = usuarioService;

            comentarios = new List<ComentarioModel>();

            InitializeComponent();

            CarregaCombo();
        }
        private void PreencheObjeto(Comentario comentario)
        {
            if (int.TryParse(cboUsuario.SelectedValue.ToString(), out var idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                comentario.Usuario = usuario;
            }

            if (int.TryParse(cboPost.SelectedValue.ToString(), out var idPost))
            {
                var post = _postService.GetById<Post>(idPost);
                comentario.Post = post;
            }

            if (DateTime.TryParse(txtData.Text, out var dataCompra))
            {
                comentario.DateComentario = dataCompra;
            }
            comentario.Texto = txtTexto.Text;
        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var comentario = _comentarioService.GetById<Comentario>(id);
                        PreencheObjeto(comentario);
                        comentario = _comentarioService.Update<Comentario, Comentario, ComentarioValidator>(comentario);
                    }
                }
                else
                {
                    var comentario = new Comentario();
                    PreencheObjeto(comentario);
                    _comentarioService.Add<Comentario, Comentario, ComentarioValidator>(comentario);

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
                _comentarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            comentarios = _comentarioService.Get<ComentarioModel>(false, new[] { "Usuario", "Post" }).ToList();
            dataGridViewConsulta.DataSource = comentarios;
            dataGridViewConsulta.Columns["IdUsuario"]!.Visible = false;
            dataGridViewConsulta.Columns["IdPost"]!.Visible = false;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtData.Text = DateTime.TryParse(linha?.Cells["DateComentario"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";
            cboUsuario.SelectedValue = linha?.Cells["IdUsuario"].Value;
            cboPost.SelectedValue = linha?.Cells["IdPost"].Value;
            txtTexto.Text = linha?.Cells["Texto"].Value.ToString();

        }
        private void CarregaCombo()
        {
            cboUsuario.ValueMember = "Id";
            cboUsuario.DisplayMember = "Nome";
            cboUsuario.DataSource = _usuarioService.Get<UsuarioModel>().ToList();

            cboPost.ValueMember = "Id";
            cboPost.DisplayMember = "Nome";
            cboPost.DataSource = _postService.Get<PostModel>().ToList();
        }
    }
}
