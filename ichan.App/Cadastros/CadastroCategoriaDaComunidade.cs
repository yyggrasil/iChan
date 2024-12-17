using ichan.App.Base;
using ichan.App.Models;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;

namespace ichan.App.Cadastros
{
    public partial class CadastroCategoriaDaComunidade : CadastroBase
    {
        private List<CategoriaDaComunidadeModel> catDaComunList;

        private readonly IBaseService<CategoriaDaComunidade> _catDaComunService;
        private readonly IBaseService<Categoria> _categoriaService;
        private readonly IBaseService<Comunidade> _comunidadeService;

        public CadastroCategoriaDaComunidade(IBaseService<CategoriaDaComunidade> catDaComunService,
                                                IBaseService<Categoria> categoriaService,
                                                IBaseService<Comunidade> comunidadeService)
        {
            _catDaComunService = catDaComunService;
            _categoriaService = categoriaService;
            _comunidadeService = comunidadeService;

            catDaComunList = new List<CategoriaDaComunidadeModel>();

            InitializeComponent();

            CarregarComboCategoria();
            CarregarComboComunidade();
        }


        private void PreencheObjeto(CategoriaDaComunidade categoriaDaComunidade)
        {
            if (int.TryParse(cboComunidade.SelectedValue.ToString(), out var idComunidade))
            {
                var comunidade = _comunidadeService.GetById<Comunidade>(idComunidade);
                categoriaDaComunidade.Comunidade = comunidade;
            }

            if (int.TryParse(cboCategoria.SelectedValue.ToString(), out var idCategoria))
            {
                var categoria = _categoriaService.GetById<Categoria>(idCategoria);
                categoriaDaComunidade.Categoria = categoria;
            }
        }

        protected override void Novo()
        {
            base.Novo();
            CarregarComboCategoria();
            CarregarComboComunidade();
        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var categoriaDaComunidade = _catDaComunService.GetById<CategoriaDaComunidade>(id);
                        PreencheObjeto(categoriaDaComunidade);
                        categoriaDaComunidade = _catDaComunService
                            .Update<CategoriaDaComunidade, CategoriaDaComunidade, CategoriaDaComunidadeValidator>(categoriaDaComunidade);
                    }
                }
                else
                {
                    var categoriaDaComunidade = new CategoriaDaComunidade();
                    PreencheObjeto(categoriaDaComunidade);
                    categoriaDaComunidade = _catDaComunService.Add<CategoriaDaComunidade, CategoriaDaComunidade, CategoriaDaComunidadeValidator>((CategoriaDaComunidade)categoriaDaComunidade);
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
                _catDaComunService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Categoria", "Comunidade" };
            catDaComunList = _catDaComunService.Get<CategoriaDaComunidadeModel>(false, includes).ToList();
            dataGridViewConsulta.DataSource = catDaComunList;
            dataGridViewConsulta.Columns["IdCategoria"]!.Visible = false;
            dataGridViewConsulta.Columns["IdComunidade"]!.Visible = false;
            dataGridViewConsulta.Columns["Comunidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();

            var categoriaDaComunidade = _catDaComunService.GetById<CategoriaDaComunidade>(id, true);
            cboCategoria.SelectedValue = linha?.Cells["Categoria"].Value;
            cboComunidade.SelectedValue = linha?.Cells["Comunidade"].Value;

        }
        private void CarregarComboCategoria()
        {
            cboCategoria.DataSource = _categoriaService.Get<CategoriaModel>().ToList();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Nome";
        }
        private void CarregarComboComunidade()
        {
            cboComunidade.ValueMember = "Id";
            cboComunidade.DisplayMember = "Nome";
            cboComunidade.DataSource = _comunidadeService.Get<ComunidadeModel>().ToList();
        }
    }
}
