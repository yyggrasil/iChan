using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;
using ReaLTaiizor.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ichan.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Usuario> _usuarioService;
        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObterUsuario(txtUsuario.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválida!", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                FormPrincipal.usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private Usuario? ObterUsuario(string email, string senha)
        {
            ChecaExistenciaDeUsuarioCadastrado();
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Email == email).FirstOrDefault();
            if (usuario == null)
                return null;
            return usuario.Senha != senha ? null : usuario;
        }
        private void ChecaExistenciaDeUsuarioCadastrado()
        {
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    Email = "admin@gmail.com",
                    Senha = "admin",
                    Nome = "admin",
                    Bios = "Administrador do sistema"
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
