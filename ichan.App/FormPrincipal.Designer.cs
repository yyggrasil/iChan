﻿namespace ichan.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
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
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, toolStripTextBox1 });
            menuStrip.Location = new Point(3, 64);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(907, 31);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, categoriaDaComunidadeToolStripMenuItem, comentarioToolStripMenuItem, comunidadeToolStripMenuItem, postToolStripMenuItem, seguidorToolStripMenuItem, usuárioToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 27);
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(3, 575);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(907, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.Text = "Usuario: ";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Text = "Bem Vindo: ";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(913, 604);
            Controls.Add(statusStrip1);
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripTextBox toolStripTextBox1;
    }
}
