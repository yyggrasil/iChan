namespace ichan.App.Outros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnOk = new ReaLTaiizor.Controls.MaterialButton();
            linkCadastro = new LinkLabel();
            textoCadatro = new Label();
            TabControlLogin = new ReaLTaiizor.Controls.MaterialTabControl();
            TabEntrar = new TabPage();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            tabCadastroUsuario = new TabPage();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            BtnCadastrar = new ReaLTaiizor.Controls.MaterialButton();
            TxtConfirmarSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TxtSenhaCadastro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TxtEmailCadastro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TxtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            bigLabelCadastro = new ReaLTaiizor.Controls.BigLabel();
            TabControlLogin.SuspendLayout();
            TabEntrar.SuspendLayout();
            tabCadastroUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha *";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(19, 186);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(392, 48);
            txtSenha.TabIndex = 1;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.AutoCompleteMode = AutoCompleteMode.None;
            txtUsuario.AutoCompleteSource = AutoCompleteSource.None;
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.HideSelection = true;
            txtUsuario.Hint = "Email ou nome de usuário *";
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(19, 98);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.PrefixSuffixText = null;
            txtUsuario.ReadOnly = false;
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.ShortcutsEnabled = true;
            txtUsuario.Size = new Size(392, 48);
            txtUsuario.TabIndex = 0;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Left;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(257, 363);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOk.Depth = 0;
            btnOk.HighEmphasis = true;
            btnOk.Icon = null;
            btnOk.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnOk.Location = new Point(370, 363);
            btnOk.Margin = new Padding(4, 6, 4, 6);
            btnOk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnOk.Name = "btnOk";
            btnOk.NoAccentTextColor = Color.Empty;
            btnOk.Size = new Size(64, 36);
            btnOk.TabIndex = 2;
            btnOk.Text = "&Ok";
            btnOk.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOk.UseAccentColor = false;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // linkCadastro
            // 
            linkCadastro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkCadastro.AutoSize = true;
            linkCadastro.Location = new Point(148, 368);
            linkCadastro.Name = "linkCadastro";
            linkCadastro.Size = new Size(87, 20);
            linkCadastro.TabIndex = 2;
            linkCadastro.TabStop = true;
            linkCadastro.Text = "Cadastra-se";
            linkCadastro.LinkClicked += linkCadastro_LinkClicked;
            // 
            // textoCadatro
            // 
            textoCadatro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textoCadatro.AutoSize = true;
            textoCadatro.Location = new Point(21, 368);
            textoCadatro.Name = "textoCadatro";
            textoCadatro.Size = new Size(130, 20);
            textoCadatro.TabIndex = 5;
            textoCadatro.Text = "Primeira vez aqui?";
            // 
            // TabControlLogin
            // 
            TabControlLogin.Controls.Add(TabEntrar);
            TabControlLogin.Controls.Add(tabCadastroUsuario);
            TabControlLogin.Depth = 0;
            TabControlLogin.Dock = DockStyle.Fill;
            TabControlLogin.Location = new Point(3, 64);
            TabControlLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlLogin.Multiline = true;
            TabControlLogin.Name = "TabControlLogin";
            TabControlLogin.SelectedIndex = 0;
            TabControlLogin.Size = new Size(449, 441);
            TabControlLogin.TabIndex = 6;
            // 
            // TabEntrar
            // 
            TabEntrar.Controls.Add(bigLabel1);
            TabEntrar.Controls.Add(linkCadastro);
            TabEntrar.Controls.Add(txtUsuario);
            TabEntrar.Controls.Add(btnCancelar);
            TabEntrar.Controls.Add(txtSenha);
            TabEntrar.Controls.Add(btnOk);
            TabEntrar.Controls.Add(textoCadatro);
            TabEntrar.Location = new Point(4, 29);
            TabEntrar.Name = "TabEntrar";
            TabEntrar.Padding = new Padding(3);
            TabEntrar.Size = new Size(441, 408);
            TabEntrar.TabIndex = 0;
            TabEntrar.Text = "Entrar";
            TabEntrar.UseVisualStyleBackColor = true;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(148, 24);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(135, 57);
            bigLabel1.TabIndex = 6;
            bigLabel1.Text = "Entrar";
            // 
            // tabCadastroUsuario
            // 
            tabCadastroUsuario.Controls.Add(label1);
            tabCadastroUsuario.Controls.Add(linkLabel1);
            tabCadastroUsuario.Controls.Add(BtnCadastrar);
            tabCadastroUsuario.Controls.Add(TxtConfirmarSenha);
            tabCadastroUsuario.Controls.Add(TxtSenhaCadastro);
            tabCadastroUsuario.Controls.Add(TxtEmailCadastro);
            tabCadastroUsuario.Controls.Add(TxtNome);
            tabCadastroUsuario.Controls.Add(bigLabelCadastro);
            tabCadastroUsuario.Location = new Point(4, 29);
            tabCadastroUsuario.Name = "tabCadastroUsuario";
            tabCadastroUsuario.Padding = new Padding(3);
            tabCadastroUsuario.Size = new Size(441, 408);
            tabCadastroUsuario.TabIndex = 1;
            tabCadastroUsuario.Text = "Cadastro";
            tabCadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(104, 337);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 8;
            label1.Text = "Já possui conta?";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(226, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Entrar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCadastrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCadastrar.Depth = 0;
            BtnCadastrar.HighEmphasis = true;
            BtnCadastrar.Icon = null;
            BtnCadastrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BtnCadastrar.Location = new Point(152, 363);
            BtnCadastrar.Margin = new Padding(4, 6, 4, 6);
            BtnCadastrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.NoAccentTextColor = Color.Empty;
            BtnCadastrar.Size = new Size(106, 36);
            BtnCadastrar.TabIndex = 5;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnCadastrar.UseAccentColor = false;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // TxtConfirmarSenha
            // 
            TxtConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtConfirmarSenha.AnimateReadOnly = false;
            TxtConfirmarSenha.AutoCompleteMode = AutoCompleteMode.None;
            TxtConfirmarSenha.AutoCompleteSource = AutoCompleteSource.None;
            TxtConfirmarSenha.BackgroundImageLayout = ImageLayout.None;
            TxtConfirmarSenha.CharacterCasing = CharacterCasing.Normal;
            TxtConfirmarSenha.Depth = 0;
            TxtConfirmarSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtConfirmarSenha.HideSelection = true;
            TxtConfirmarSenha.Hint = "Confirmar Senha*";
            TxtConfirmarSenha.LeadingIcon = null;
            TxtConfirmarSenha.Location = new Point(6, 261);
            TxtConfirmarSenha.MaxLength = 32767;
            TxtConfirmarSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            TxtConfirmarSenha.PasswordChar = '\0';
            TxtConfirmarSenha.PrefixSuffixText = null;
            TxtConfirmarSenha.ReadOnly = false;
            TxtConfirmarSenha.RightToLeft = RightToLeft.No;
            TxtConfirmarSenha.SelectedText = "";
            TxtConfirmarSenha.SelectionLength = 0;
            TxtConfirmarSenha.SelectionStart = 0;
            TxtConfirmarSenha.ShortcutsEnabled = true;
            TxtConfirmarSenha.Size = new Size(422, 48);
            TxtConfirmarSenha.TabIndex = 4;
            TxtConfirmarSenha.TabStop = false;
            TxtConfirmarSenha.TextAlign = HorizontalAlignment.Left;
            TxtConfirmarSenha.TrailingIcon = null;
            TxtConfirmarSenha.UseSystemPasswordChar = false;
            // 
            // TxtSenhaCadastro
            // 
            TxtSenhaCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSenhaCadastro.AnimateReadOnly = false;
            TxtSenhaCadastro.AutoCompleteMode = AutoCompleteMode.None;
            TxtSenhaCadastro.AutoCompleteSource = AutoCompleteSource.None;
            TxtSenhaCadastro.BackgroundImageLayout = ImageLayout.None;
            TxtSenhaCadastro.CharacterCasing = CharacterCasing.Normal;
            TxtSenhaCadastro.Depth = 0;
            TxtSenhaCadastro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtSenhaCadastro.HideSelection = true;
            TxtSenhaCadastro.Hint = "Senha*";
            TxtSenhaCadastro.LeadingIcon = null;
            TxtSenhaCadastro.Location = new Point(3, 207);
            TxtSenhaCadastro.MaxLength = 32767;
            TxtSenhaCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtSenhaCadastro.Name = "TxtSenhaCadastro";
            TxtSenhaCadastro.PasswordChar = '\0';
            TxtSenhaCadastro.PrefixSuffixText = null;
            TxtSenhaCadastro.ReadOnly = false;
            TxtSenhaCadastro.RightToLeft = RightToLeft.No;
            TxtSenhaCadastro.SelectedText = "";
            TxtSenhaCadastro.SelectionLength = 0;
            TxtSenhaCadastro.SelectionStart = 0;
            TxtSenhaCadastro.ShortcutsEnabled = true;
            TxtSenhaCadastro.Size = new Size(425, 48);
            TxtSenhaCadastro.TabIndex = 3;
            TxtSenhaCadastro.TabStop = false;
            TxtSenhaCadastro.TextAlign = HorizontalAlignment.Left;
            TxtSenhaCadastro.TrailingIcon = null;
            TxtSenhaCadastro.UseSystemPasswordChar = false;
            // 
            // TxtEmailCadastro
            // 
            TxtEmailCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtEmailCadastro.AnimateReadOnly = false;
            TxtEmailCadastro.AutoCompleteMode = AutoCompleteMode.None;
            TxtEmailCadastro.AutoCompleteSource = AutoCompleteSource.None;
            TxtEmailCadastro.BackgroundImageLayout = ImageLayout.None;
            TxtEmailCadastro.CharacterCasing = CharacterCasing.Normal;
            TxtEmailCadastro.Depth = 0;
            TxtEmailCadastro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtEmailCadastro.HideSelection = true;
            TxtEmailCadastro.Hint = "Email*";
            TxtEmailCadastro.LeadingIcon = null;
            TxtEmailCadastro.Location = new Point(6, 140);
            TxtEmailCadastro.MaxLength = 32767;
            TxtEmailCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtEmailCadastro.Name = "TxtEmailCadastro";
            TxtEmailCadastro.PasswordChar = '\0';
            TxtEmailCadastro.PrefixSuffixText = null;
            TxtEmailCadastro.ReadOnly = false;
            TxtEmailCadastro.RightToLeft = RightToLeft.No;
            TxtEmailCadastro.SelectedText = "";
            TxtEmailCadastro.SelectionLength = 0;
            TxtEmailCadastro.SelectionStart = 0;
            TxtEmailCadastro.ShortcutsEnabled = true;
            TxtEmailCadastro.Size = new Size(422, 48);
            TxtEmailCadastro.TabIndex = 2;
            TxtEmailCadastro.TabStop = false;
            TxtEmailCadastro.TextAlign = HorizontalAlignment.Left;
            TxtEmailCadastro.TrailingIcon = null;
            TxtEmailCadastro.UseSystemPasswordChar = false;
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNome.AnimateReadOnly = false;
            TxtNome.AutoCompleteMode = AutoCompleteMode.None;
            TxtNome.AutoCompleteSource = AutoCompleteSource.None;
            TxtNome.BackgroundImageLayout = ImageLayout.None;
            TxtNome.CharacterCasing = CharacterCasing.Normal;
            TxtNome.Depth = 0;
            TxtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtNome.HideSelection = true;
            TxtNome.Hint = "Nome*";
            TxtNome.LeadingIcon = null;
            TxtNome.Location = new Point(6, 73);
            TxtNome.MaxLength = 32767;
            TxtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtNome.Name = "TxtNome";
            TxtNome.PasswordChar = '\0';
            TxtNome.PrefixSuffixText = null;
            TxtNome.ReadOnly = false;
            TxtNome.RightToLeft = RightToLeft.No;
            TxtNome.SelectedText = "";
            TxtNome.SelectionLength = 0;
            TxtNome.SelectionStart = 0;
            TxtNome.ShortcutsEnabled = true;
            TxtNome.Size = new Size(422, 48);
            TxtNome.TabIndex = 1;
            TxtNome.TabStop = false;
            TxtNome.TextAlign = HorizontalAlignment.Left;
            TxtNome.TrailingIcon = null;
            TxtNome.UseSystemPasswordChar = false;
            // 
            // bigLabelCadastro
            // 
            bigLabelCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bigLabelCadastro.AutoSize = true;
            bigLabelCadastro.BackColor = Color.Transparent;
            bigLabelCadastro.Font = new Font("Segoe UI", 25F);
            bigLabelCadastro.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabelCadastro.Location = new Point(119, 3);
            bigLabelCadastro.Name = "bigLabelCadastro";
            bigLabelCadastro.Size = new Size(190, 57);
            bigLabelCadastro.TabIndex = 0;
            bigLabelCadastro.Text = "Cadastro";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 508);
            Controls.Add(TabControlLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TabControlLogin.ResumeLayout(false);
            TabEntrar.ResumeLayout(false);
            TabEntrar.PerformLayout();
            tabCadastroUsuario.ResumeLayout(false);
            tabCadastroUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnOk;
        private LinkLabel linkCadastro;
        private Label textoCadatro;
        private ReaLTaiizor.Controls.MaterialTabControl TabControlLogin;
        private TabPage TabEntrar;
        private TabPage tabCadastroUsuario;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabelCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtConfirmarSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtSenhaCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtEmailCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtNome;
        private ReaLTaiizor.Controls.MaterialButton BtnCadastrar;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}