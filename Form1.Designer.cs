namespace WindowsFormsApp2
{
    partial class F_escola
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this.lb_nivel = new System.Windows.Forms.Label();
			this.user = new System.Windows.Forms.Label();
			this.lb_user = new System.Windows.Forms.Label();
			this.nivel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pb_login = new System.Windows.Forms.PictureBox();
			this.novoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.lb_nivel);
			this.panel1.Controls.Add(this.pb_login);
			this.panel1.Controls.Add(this.user);
			this.panel1.Controls.Add(this.lb_user);
			this.panel1.Controls.Add(this.nivel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 401);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(365, 49);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lb_nivel
			// 
			this.lb_nivel.AutoSize = true;
			this.lb_nivel.Location = new System.Drawing.Point(178, 27);
			this.lb_nivel.Name = "lb_nivel";
			this.lb_nivel.Size = new System.Drawing.Size(13, 13);
			this.lb_nivel.TabIndex = 5;
			this.lb_nivel.Text = "--";
			// 
			// user
			// 
			this.user.AutoSize = true;
			this.user.Location = new System.Drawing.Point(49, 27);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(46, 13);
			this.user.TabIndex = 2;
			this.user.Text = "Usuário:";
			// 
			// lb_user
			// 
			this.lb_user.AutoSize = true;
			this.lb_user.Location = new System.Drawing.Point(101, 27);
			this.lb_user.Name = "lb_user";
			this.lb_user.Size = new System.Drawing.Size(13, 13);
			this.lb_user.TabIndex = 3;
			this.lb_user.Text = "--";
			// 
			// nivel
			// 
			this.nivel.AutoSize = true;
			this.nivel.Location = new System.Drawing.Point(136, 27);
			this.nivel.Name = "nivel";
			this.nivel.Size = new System.Drawing.Size(36, 13);
			this.nivel.TabIndex = 4;
			this.nivel.Text = "Nível:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.cursosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(365, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoffToolStripMenuItem});
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.loginToolStripMenuItem.Text = "Login";
			// 
			// logonToolStripMenuItem
			// 
			this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
			this.logonToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.logonToolStripMenuItem.Text = "Logon";
			this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
			// 
			// logoffToolStripMenuItem
			// 
			this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
			this.logoffToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.logoffToolStripMenuItem.Text = "Logoff";
			// 
			// usuáriosToolStripMenuItem
			// 
			this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.gerenciamentoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.visualizarToolStripMenuItem});
			this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
			this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.usuáriosToolStripMenuItem.Text = "Usuários";
			// 
			// novoToolStripMenuItem
			// 
			this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
			this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.novoToolStripMenuItem.Text = "Novo";
			this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
			// 
			// gerenciamentoToolStripMenuItem
			// 
			this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
			this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
			// 
			// visualizarToolStripMenuItem
			// 
			this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
			this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.visualizarToolStripMenuItem.Text = "Visualizar";
			// 
			// alunosToolStripMenuItem
			// 
			this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
			this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.alunosToolStripMenuItem.Text = "Alunos";
			// 
			// cursosToolStripMenuItem
			// 
			this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCursoToolStripMenuItem});
			this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
			this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.cursosToolStripMenuItem.Text = "Cursos";
			// 
			// pb_login
			// 
			this.pb_login.Image = global::WindowsFormsApp2.Properties.Resources.bvermelha;
			this.pb_login.Location = new System.Drawing.Point(9, 16);
			this.pb_login.Name = "pb_login";
			this.pb_login.Size = new System.Drawing.Size(25, 24);
			this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_login.TabIndex = 1;
			this.pb_login.TabStop = false;
			// 
			// novoCursoToolStripMenuItem
			// 
			this.novoCursoToolStripMenuItem.Name = "novoCursoToolStripMenuItem";
			this.novoCursoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.novoCursoToolStripMenuItem.Text = "Novo curso";
			this.novoCursoToolStripMenuItem.Click += new System.EventHandler(this.novoCursoToolStripMenuItem_Click);
			// 
			// F_escola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "F_escola";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
		public System.Windows.Forms.PictureBox pb_login;
		public System.Windows.Forms.Label lb_user;
		public System.Windows.Forms.Label lb_nivel;
		private System.Windows.Forms.ToolStripMenuItem novoCursoToolStripMenuItem;
	}
}

