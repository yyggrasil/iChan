namespace ichan.App.Cadastros
{
    partial class CadastroComentario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroComentario));
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTexto = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            cboPost = new ReaLTaiizor.Controls.MaterialComboBox();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(cboUsuario);
            tabPageCadastro.Controls.Add(cboPost);
            tabPageCadastro.Controls.Add(txtTexto);
            tabPageCadastro.Controls.Add(txtData);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtData, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTexto, 0);
            tabPageCadastro.Controls.SetChildIndex(cboPost, 0);
            tabPageCadastro.Controls.SetChildIndex(cboUsuario, 0);
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
            txtId.Size = new Size(151, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
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
            txtData.Hint = "Data de Publicação";
            txtData.InsertKeyMode = InsertKeyMode.Default;
            txtData.LeadingIcon = null;
            txtData.Location = new Point(163, 6);
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
            txtData.Size = new Size(163, 48);
            txtData.SkipLiterals = true;
            txtData.TabIndex = 2;
            txtData.TabStop = false;
            txtData.Text = "  /  /";
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            txtData.ValidatingType = null;
            // 
            // txtTexto
            // 
            txtTexto.AnimateReadOnly = false;
            txtTexto.BackgroundImageLayout = ImageLayout.None;
            txtTexto.CharacterCasing = CharacterCasing.Normal;
            txtTexto.Depth = 0;
            txtTexto.HideSelection = true;
            txtTexto.Hint = "Comentário";
            txtTexto.Location = new Point(6, 115);
            txtTexto.MaxLength = 32767;
            txtTexto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTexto.Name = "txtTexto";
            txtTexto.PasswordChar = '\0';
            txtTexto.ReadOnly = false;
            txtTexto.ScrollBars = ScrollBars.None;
            txtTexto.SelectedText = "";
            txtTexto.SelectionLength = 0;
            txtTexto.SelectionStart = 0;
            txtTexto.ShortcutsEnabled = true;
            txtTexto.Size = new Size(773, 160);
            txtTexto.TabIndex = 3;
            txtTexto.TabStop = false;
            txtTexto.TextAlign = HorizontalAlignment.Left;
            txtTexto.UseSystemPasswordChar = false;
            // 
            // cboPost
            // 
            cboPost.AutoResize = false;
            cboPost.BackColor = Color.FromArgb(255, 255, 255);
            cboPost.Depth = 0;
            cboPost.DrawMode = DrawMode.OwnerDrawVariable;
            cboPost.DropDownHeight = 174;
            cboPost.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPost.DropDownWidth = 121;
            cboPost.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPost.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPost.FormattingEnabled = true;
            cboPost.Hint = "Post";
            cboPost.IntegralHeight = false;
            cboPost.ItemHeight = 43;
            cboPost.Location = new Point(7, 60);
            cboPost.MaxDropDownItems = 4;
            cboPost.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPost.Name = "cboPost";
            cboPost.Size = new Size(772, 49);
            cboPost.StartIndex = 0;
            cboPost.TabIndex = 4;
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
            cboUsuario.Enabled = false;
            cboUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Hint = "Usuário";
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new Point(332, 6);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(447, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 5;
            // 
            // CadastroComentario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroComentario";
            Text = "Cadastro Comentário";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtTexto;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
        private ReaLTaiizor.Controls.MaterialComboBox cboPost;
    }
}