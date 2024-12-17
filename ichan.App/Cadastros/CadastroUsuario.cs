using ichan.App.Base;
using ichan.App.Models;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;

namespace ichan.App.Cadastros
{
    public partial class CadastroUsuario : CadastroBase
    {
        private List<UsuarioModel> usuarios;
        private readonly IBaseService<Usuario> _usuarioService;
        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            usuarios = new List<UsuarioModel>();
            InitializeComponent();
        }
        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Senha = txtSenha.Text;
            usuario.Bios = txtBios.Text;
            usuario.Email = txtEmail.Text;
            usuario.Nome = txtNome.Text;
        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    usuario = _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
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
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<UsuarioModel>(false).ToList();
            dataGridViewConsulta.DataSource = usuarios;
            dataGridViewConsulta.Columns["Senha"]!.Visible = false;
            dataGridViewConsulta.AutoResizeColumns();
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtBios.Text = linha?.Cells["Bios"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
        }
    }
}
