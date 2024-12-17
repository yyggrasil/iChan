namespace ichan.App.Cadastros
{
    partial class CadastroPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPost));
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            cboComunidade = new ReaLTaiizor.Controls.MaterialComboBox();
            txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtConteudo = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.Images.SetKeyName(0, "form.png");
            imageList.Images.SetKeyName(1, "search.png");
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtConteudo);
            tabPageCadastro.Controls.Add(txtTitulo);
            tabPageCadastro.Controls.Add(txtData);
            tabPageCadastro.Controls.Add(cboComunidade);
            tabPageCadastro.Controls.Add(cboUsuario);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(cboComunidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtData, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTitulo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtConteudo, 0);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(6, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(73, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboUsuario
            // 
            cboUsuario.AutoResize = false;
            cboUsuario.BackColor = Color.FromArgb(255, 255, 255);
            cboUsuario.Depth = 0;
            cboUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            cboUsuario.DropDownHeight = 174;
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.DropDownWidth = 121;
            cboUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Hint = "Usuário";
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new Point(85, 6);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(275, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 3;
            // 
            // cboComunidade
            // 
            cboComunidade.AutoResize = false;
            cboComunidade.BackColor = Color.FromArgb(255, 255, 255);
            cboComunidade.Depth = 0;
            cboComunidade.DrawMode = DrawMode.OwnerDrawVariable;
            cboComunidade.DropDownHeight = 174;
            cboComunidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboComunidade.DropDownWidth = 121;
            cboComunidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboComunidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboComunidade.FormattingEnabled = true;
            cboComunidade.Hint = "Comunidade";
            cboComunidade.IntegralHeight = false;
            cboComunidade.ItemHeight = 43;
            cboComunidade.Location = new Point(366, 6);
            cboComunidade.MaxDropDownItems = 4;
            cboComunidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboComunidade.Name = "cboComunidade";
            cboComunidade.Size = new Size(413, 49);
            cboComunidade.StartIndex = 0;
            cboComunidade.TabIndex = 4;
            // 
            // txtData
            // 
            txtData.AllowPromptAsInput = true;
            txtData.AnimateReadOnly = false;
            txtData.AsciiOnly = false;
            txtData.BackgroundImageLayout = ImageLayout.None;
            txtData.BeepOnError = false;
            txtData.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtData.Depth = 0;
            txtData.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtData.HidePromptOnLeave = false;
            txtData.HideSelection = true;
            txtData.Hint = "Data Criação";
            txtData.InsertKeyMode = InsertKeyMode.Default;
            txtData.LeadingIcon = null;
            txtData.Location = new Point(538, 60);
            txtData.Mask = "99/99/9999";
            txtData.MaxLength = 32767;
            txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.PrefixSuffixText = null;
            txtData.PromptChar = '_';
            txtData.ReadOnly = false;
            txtData.RejectInputOnFirstFailure = false;
            txtData.ResetOnPrompt = true;
            txtData.ResetOnSpace = true;
            txtData.RightToLeft = RightToLeft.No;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.ShortcutsEnabled = true;
            txtData.Size = new Size(241, 48);
            txtData.SkipLiterals = true;
            txtData.TabIndex = 5;
            txtData.TabStop = false;
            txtData.Text = "  /  /";
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            txtData.ValidatingType = null;
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.Hint = "Titulo";
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(6, 60);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(526, 48);
            txtTitulo.TabIndex = 6;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtConteudo
            // 
            txtConteudo.AnimateReadOnly = false;
            txtConteudo.BackgroundImageLayout = ImageLayout.None;
            txtConteudo.CharacterCasing = CharacterCasing.Normal;
            txtConteudo.Depth = 0;
            txtConteudo.HideSelection = true;
            txtConteudo.Hint = "Conteudo";
            txtConteudo.Location = new Point(6, 114);
            txtConteudo.MaxLength = 32767;
            txtConteudo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtConteudo.Name = "txtConteudo";
            txtConteudo.PasswordChar = '\0';
            txtConteudo.ReadOnly = false;
            txtConteudo.ScrollBars = ScrollBars.None;
            txtConteudo.SelectedText = "";
            txtConteudo.SelectionLength = 0;
            txtConteudo.SelectionStart = 0;
            txtConteudo.ShortcutsEnabled = true;
            txtConteudo.Size = new Size(774, 185);
            txtConteudo.TabIndex = 7;
            txtConteudo.TabStop = false;
            txtConteudo.TextAlign = HorizontalAlignment.Left;
            txtConteudo.UseSystemPasswordChar = false;
            // 
            // CadastroPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroPost";
            Text = "CadastroPost";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboComunidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtConteudo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
    }
}