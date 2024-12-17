using ichan.App.Cadastros;
using ichan.App.Infra;
using ichan.App.Outros;
using ichan.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace ichan.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuario usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }
        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUsuario.Text = $"Usuário: {usuario.Nome}";
                }
            }
        }

        private void comentarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroComentario>();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCategoria>();
        }

        private void categoriaDaComunidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCategoriaDaComunidade>();
        }

        private void comunidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroComunidade>();
        }

        private void postToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPost>();
        }

        private void seguidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroSegue>();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuario>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}

