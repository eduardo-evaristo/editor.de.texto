namespace EditorDeTexto
{
    partial class Form1
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
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            selecionarTudoToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            validarToolStripMenuItem1 = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.DetectUrls = false;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(859, 477);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editarToolStripMenuItem, validarToolStripMenuItem1, adicionarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(859, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, sairToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(61, 20);
            fileToolStripMenuItem.Text = "Arquivo";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            novoToolStripMenuItem.Size = new Size(146, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.K;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "Abrir";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "Salvar";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(146, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selecionarTudoToolStripMenuItem, copiarToolStripMenuItem, colarToolStripMenuItem, recortarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // selecionarTudoToolStripMenuItem
            // 
            selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            selecionarTudoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selecionarTudoToolStripMenuItem.Size = new Size(200, 22);
            selecionarTudoToolStripMenuItem.Text = "Selecionar Tudo";
            selecionarTudoToolStripMenuItem.Click += selecionarTudoToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(200, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(200, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // recortarToolStripMenuItem
            // 
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            recortarToolStripMenuItem.Size = new Size(200, 22);
            recortarToolStripMenuItem.Text = "Recortar";
            recortarToolStripMenuItem.Click += recortarToolStripMenuItem_Click;
            // 
            // validarToolStripMenuItem1
            // 
            validarToolStripMenuItem1.Name = "validarToolStripMenuItem1";
            validarToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.E;
            validarToolStripMenuItem1.Size = new Size(54, 20);
            validarToolStripMenuItem1.Text = "Validar";
            validarToolStripMenuItem1.Click += validarToolStripMenuItem1_Click;
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(136, 20);
            adicionarToolStripMenuItem.Text = "Adicionar a Dicionário";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(859, 501);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Editor de Texto";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem validarToolStripMenuItem1;
        private ToolStripMenuItem adicionarToolStripMenuItem;
    }
}
