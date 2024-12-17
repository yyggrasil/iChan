namespace ichan.App.Cadastros
{
    partial class CadastroCategoriaDaComunidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCategoriaDaComunidade));
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboComunidade = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(cboCategoria);
            tabPageCadastro.Controls.Add(cboComunidade);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboComunidade, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCategoria, 0);
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
            txtId.Size = new Size(54, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
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
            cboComunidade.Location = new Point(66, 6);
            cboComunidade.MaxDropDownItems = 4;
            cboComunidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboComunidade.Name = "cboComunidade";
            cboComunidade.Size = new Size(338, 49);
            cboComunidade.StartIndex = 0;
            cboComunidade.TabIndex = 5;
            // 
            // cboCategoria
            // 
            cboCategoria.AutoResize = false;
            cboCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cboCategoria.Depth = 0;
            cboCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cboCategoria.DropDownHeight = 174;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.DropDownWidth = 121;
            cboCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Hint = "Categoria";
            cboCategoria.IntegralHeight = false;
            cboCategoria.ItemHeight = 43;
            cboCategoria.Location = new Point(410, 6);
            cboCategoria.MaxDropDownItems = 4;
            cboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(369, 49);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 6;
            // 
            // CadastroCategoriaDaComunidade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroCategoriaDaComunidade";
            Text = "Cadastro de categoria para comundiade";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox cboComunidade;
    }
}