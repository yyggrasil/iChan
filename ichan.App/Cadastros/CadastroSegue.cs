using ichan.App.Base;
using ichan.App.Models;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Service.Validators;

namespace ichan.App.Cadastros
{
    public partial class CadastroSegue : CadastroBase
    {
        private List<SegueModel> seguidores;
        private readonly IBaseService<Segue> _segueService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Comunidade> _comunidadeService;

        public CadastroSegue(IBaseService<Segue> segueService,
                                IBaseService<Usuario> usuarioService,
                                IBaseService<Comunidade> comunidadeService)
        {
            _segueService = segueService;
            _usuarioService = usuarioService;
            _comunidadeService = comunidadeService;

            seguidores = new List<SegueModel>();
            InitializeComponent();
            CarregaCombo();
            Novo();
        }

        private void PreencheObjeto(Segue segue)
        {
            if (int.TryParse(cboComunidade.SelectedValue.ToString(), out var idComunidade))
            {
                var comunidade = _comunidadeService.GetById<Comunidade>(idComunidade);
                segue.Comunidade = comunidade;
            }

            if (int.TryParse(cboUsuario.SelectedValue.ToString(), out var idUsuario))
            {
                var usuario = _usuarioService.GetById<Usuario>(idUsuario);
                segue.Usuario = usuario;
            }
            if (DateTime.TryParse(txtDataSegue.Text, out var dataCompra))
            {
                segue.DataSeguida = dataCompra;
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
                        var segue = _segueService.GetById<Segue>(id);
                        PreencheObjeto(segue);
                        segue = _segueService.Update<Segue, Segue, SegueValidator>(segue);
                    }
                }
                else
                {
                    var segue = new Segue();
                    PreencheObjeto(segue);
                    segue = _segueService.Add<Segue, Segue, SegueValidator>(segue);
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
                _segueService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            seguidores = _segueService.Get<SegueModel>(false, new[] { "Usuario", "Comunidade" }).ToList();
            dataGridViewConsulta.DataSource = seguidores;
            dataGridViewConsulta.Columns["IdUsuario"]!.Visible = false;
            dataGridViewConsulta.Columns["IdComunidade"]!.Visible = false;
            dataGridViewConsulta.AutoResizeColumns();
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtDataSegue.Text = DateTime.TryParse(linha?.Cells["DataSeguida"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";
            //var post = _segueService.GetById<Segue>(id, true);
            cboUsuario.SelectedValue = linha?.Cells["Usuario"].Value;
            cboComunidade.SelectedValue = linha?.Cells["Comunidade"].Value;
        }
        private void CarregaCombo()
        {
            cboComunidade.DataSource = _comunidadeService.Get<ComunidadeModel>().ToList();
            cboComunidade.ValueMember = "Id";
            cboComunidade.DisplayMember = "Nome";

            cboUsuario.DataSource = _usuarioService.Get<UsuarioModel>().ToList();
            cboUsuario.ValueMember = "Id";
            cboUsuario.DisplayMember = "Nome";
        }
        protected override void Novo()
        {
            base.Novo();
            CarregaCombo();
            txtDataSegue.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
