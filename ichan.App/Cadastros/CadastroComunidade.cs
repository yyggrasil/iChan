using ichan.App.Base;
using ichan.App.Models;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;

namespace ichan.App.Cadastros
{
    public partial class CadastroComunidade : CadastroBase
    {
        private List<ComunidadeModel> comunidades;

        private readonly IBaseService<Comentario> _comunidadeService;

        public CadastroComunidade(IBaseService<Comentario> comunidadeService)
        {
            _comunidadeService = comunidadeService;
            comunidades = new List<ComunidadeModel>();
            InitializeComponent();
        }
        private void PreencheObjeto(Comunidade comunidade)
        {
            comunidade.Nome = txtNome.Text;
            comunidade.Descricao = txtDescricao.Text;
            if (DateTime.TryParse(txtData.Text, out var dataCriacao))
            {
                comunidade.DataCriacao = dataCriacao;
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
                        var comunidade = _comunidadeService.GetById<Comunidade>(id);
                        PreencheObjeto(comunidade);
                        comunidade = _comunidadeService.Update<Comunidade, Comunidade, ComunidadeValidator>(comunidade);
                    }
                }
                else
                {
                    var comunidade = new Comunidade();
                    PreencheObjeto(comunidade);
                    _comunidadeService.Add<Comunidade, Comunidade, ComunidadeValidator>(comunidade);

                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
