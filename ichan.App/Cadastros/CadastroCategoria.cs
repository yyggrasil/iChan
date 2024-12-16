using ichan.App.Base;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;

namespace ichan.App.Cadastros
{
    public partial class CadastroCategoria : CadastroBase
    {
        private IBaseService<Categoria> _categoriaService;
        private List<Categoria> categorias;
        public CadastroCategoria(IBaseService<Categoria> categoriaService)
        {
            _categoriaService = categoriaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Categoria categoria)
        {
            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescricao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var categoria = _categoriaService.GetById<Categoria>(id);
                        PreencheObjeto(categoria);
                        categoria = _categoriaService.Update<Categoria, Categoria, CategoriaValidator>(categoria);
                    }
                }
                else
                {
                    var categoria = new Categoria();
                    PreencheObjeto(categoria);
                    _categoriaService.Add<Categoria, Categoria, CategoriaValidator>(categoria);

                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id) 
        {
            try
            {
                _categoriaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            categorias = _categoriaService.Get<Categoria>().ToList();
            dataGridViewConsulta.DataSource = categorias;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Descricao"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
        }

    }
}
