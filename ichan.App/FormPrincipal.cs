using ichan.App.Cadastros;
using ichan.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace ichan.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
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
            ExibeFormulario<CadastroComentario>();
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

