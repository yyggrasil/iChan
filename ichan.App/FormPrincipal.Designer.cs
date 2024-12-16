namespace ichan.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            categoriaDaComunidadeToolStripMenuItem = new ToolStripMenuItem();
            comentarioToolStripMenuItem = new ToolStripMenuItem();
            comunidadeToolStripMenuItem = new ToolStripMenuItem();
            postToolStripMenuItem = new ToolStripMenuItem();
            seguidorToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip.Location = new Point(3, 64);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(794, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, categoriaDaComunidadeToolStripMenuItem, comentarioToolStripMenuItem, comunidadeToolStripMenuItem, postToolStripMenuItem, seguidorToolStripMenuItem, usuárioToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(267, 26);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // categoriaDaComunidadeToolStripMenuItem
            // 
            categoriaDaComunidadeToolStripMenuItem.Name = "categoriaDaComunidadeToolStripMenuItem";
            categoriaDaComunidadeToolStripMenuItem.Size = new Size(267, 26);
            categoriaDaComunidadeToolStripMenuItem.Text = "Categoria da Comunidade";
            categoriaDaComunidadeToolStripMenuItem.Click += categoriaDaComunidadeToolStripMenuItem_Click;
            // 
            // comentarioToolStripMenuItem
            // 
            comentarioToolStripMenuItem.Name = "comentarioToolStripMenuItem";
            comentarioToolStripMenuItem.Size = new Size(267, 26);
            comentarioToolStripMenuItem.Text = "Comentario";
            comentarioToolStripMenuItem.Click += comentarioToolStripMenuItem_Click;
            // 
            // comunidadeToolStripMenuItem
            // 
            comunidadeToolStripMenuItem.Name = "comunidadeToolStripMenuItem";
            comunidadeToolStripMenuItem.Size = new Size(267, 26);
            comunidadeToolStripMenuItem.Text = "Comunidade";
            comunidadeToolStripMenuItem.Click += comunidadeToolStripMenuItem_Click;
            // 
            // postToolStripMenuItem
            // 
            postToolStripMenuItem.Name = "postToolStripMenuItem";
            postToolStripMenuItem.Size = new Size(267, 26);
            postToolStripMenuItem.Text = "Post";
            postToolStripMenuItem.Click += postToolStripMenuItem_Click;
            // 
            // seguidorToolStripMenuItem
            // 
            seguidorToolStripMenuItem.Name = "seguidorToolStripMenuItem";
            seguidorToolStripMenuItem.Size = new Size(267, 26);
            seguidorToolStripMenuItem.Text = "Seguidor";
            seguidorToolStripMenuItem.Click += seguidorToolStripMenuItem_Click;
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(267, 26);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ichan";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem categoriaDaComunidadeToolStripMenuItem;
        private ToolStripMenuItem comentarioToolStripMenuItem;
        private ToolStripMenuItem comunidadeToolStripMenuItem;
        private ToolStripMenuItem postToolStripMenuItem;
        private ToolStripMenuItem seguidorToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
    }
}
