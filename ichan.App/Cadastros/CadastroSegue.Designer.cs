namespace ichan.App.Cadastros
{
    partial class CadastroSegue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroSegue));
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataSegue = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            cboComunidade = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(cboComunidade);
            tabPageCadastro.Controls.Add(cboUsuario);
            tabPageCadastro.Controls.Add(txtDataSegue);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataSegue, 0);
            tabPageCadastro.Controls.SetChildIndex(cboUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(cboComunidade, 0);
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
            txtId.Size = new Size(64, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtDataSegue
            // 
            txtDataSegue.AllowPromptAsInput = true;
            txtDataSegue.AnimateReadOnly = false;
            txtDataSegue.AsciiOnly = false;
            txtDataSegue.BackgroundImageLayout = ImageLayout.None;
            txtDataSegue.BeepOnError = false;
            txtDataSegue.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataSegue.Depth = 0;
            txtDataSegue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataSegue.HidePromptOnLeave = false;
            txtDataSegue.HideSelection = true;
            txtDataSegue.Hint = "Data da Seguida";
            txtDataSegue.InsertKeyMode = InsertKeyMode.Default;
            txtDataSegue.LeadingIcon = null;
            txtDataSegue.Location = new Point(76, 6);
            txtDataSegue.Mask = "99/99/9999";
            txtDataSegue.MaxLength = 32767;
            txtDataSegue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataSegue.Name = "txtDataSegue";
            txtDataSegue.PasswordChar = '\0';
            txtDataSegue.PrefixSuffixText = null;
            txtDataSegue.PromptChar = '_';
            txtDataSegue.ReadOnly = false;
            txtDataSegue.RejectInputOnFirstFailure = false;
            txtDataSegue.ResetOnPrompt = true;
            txtDataSegue.ResetOnSpace = true;
            txtDataSegue.RightToLeft = RightToLeft.No;
            txtDataSegue.SelectedText = "";
            txtDataSegue.SelectionLength = 0;
            txtDataSegue.SelectionStart = 0;
            txtDataSegue.ShortcutsEnabled = true;
            txtDataSegue.Size = new Size(312, 48);
            txtDataSegue.SkipLiterals = true;
            txtDataSegue.TabIndex = 3;
            txtDataSegue.TabStop = false;
            txtDataSegue.Text = "  /  /";
            txtDataSegue.TextAlign = HorizontalAlignment.Left;
            txtDataSegue.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataSegue.TrailingIcon = null;
            txtDataSegue.UseSystemPasswordChar = false;
            txtDataSegue.ValidatingType = null;
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
            cboUsuario.Hint = "Usuario";
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new Point(6, 60);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(382, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 4;
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
            cboComunidade.Location = new Point(394, 60);
            cboComunidade.MaxDropDownItems = 4;
            cboComunidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboComunidade.Name = "cboComunidade";
            cboComunidade.Size = new Size(385, 49);
            cboComunidade.StartIndex = 0;
            cboComunidade.TabIndex = 5;
            // 
            // CadastroSegue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroSegue";
            Text = "CadastroSegue";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboComunidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataSegue;
    }
}