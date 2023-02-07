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
			this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciamentoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciamentoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tb_manual = new System.Windows.Forms.Button();
			this.pb_login = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.pb_login);
			this.panel1.Controls.Add(this.lb_nivel);
			this.panel1.Controls.Add(this.nivel);
			this.panel1.Controls.Add(this.lb_user);
			this.panel1.Controls.Add(this.user);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 402);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 48);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lb_nivel
			// 
			this.lb_nivel.AutoSize = true;
			this.lb_nivel.Location = new System.Drawing.Point(264, 23);
			this.lb_nivel.Name = "lb_nivel";
			this.lb_nivel.Size = new System.Drawing.Size(13, 13);
			this.lb_nivel.TabIndex = 5;
			this.lb_nivel.Text = "--";
			// 
			// user
			// 
			this.user.AutoSize = true;
			this.user.Location = new System.Drawing.Point(52, 23);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(46, 13);
			this.user.TabIndex = 2;
			this.user.Text = "Usuário:";
			// 
			// lb_user
			// 
			this.lb_user.AutoSize = true;
			this.lb_user.Location = new System.Drawing.Point(104, 23);
			this.lb_user.Name = "lb_user";
			this.lb_user.Size = new System.Drawing.Size(13, 13);
			this.lb_user.TabIndex = 3;
			this.lb_user.Text = "--";
			// 
			// nivel
			// 
			this.nivel.AutoSize = true;
			this.nivel.Location = new System.Drawing.Point(222, 23);
			this.nivel.Name = "nivel";
			this.nivel.Size = new System.Drawing.Size(36, 13);
			this.nivel.TabIndex = 4;
			this.nivel.Text = "Nível:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.turmasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(377, 24);
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
			this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
			// 
			// alunosToolStripMenuItem
			// 
			this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoToolStripMenuItem3});
			this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
			this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.alunosToolStripMenuItem.Text = "Alunos";
			// 
			// gerenciamentoToolStripMenuItem3
			// 
			this.gerenciamentoToolStripMenuItem3.Name = "gerenciamentoToolStripMenuItem3";
			this.gerenciamentoToolStripMenuItem3.Size = new System.Drawing.Size(155, 22);
			this.gerenciamentoToolStripMenuItem3.Text = "Gerenciamento";
			this.gerenciamentoToolStripMenuItem3.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem3_Click);
			// 
			// cursosToolStripMenuItem
			// 
			this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoToolStripMenuItem2});
			this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
			this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.cursosToolStripMenuItem.Text = "Cursos";
			// 
			// gerenciamentoToolStripMenuItem2
			// 
			this.gerenciamentoToolStripMenuItem2.Name = "gerenciamentoToolStripMenuItem2";
			this.gerenciamentoToolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
			this.gerenciamentoToolStripMenuItem2.Text = "Gerenciamento";
			this.gerenciamentoToolStripMenuItem2.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem2_Click);
			// 
			// usuáriosToolStripMenuItem
			// 
			this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoToolStripMenuItem});
			this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
			this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.usuáriosToolStripMenuItem.Text = "Usuários";
			// 
			// gerenciamentoToolStripMenuItem
			// 
			this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
			this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
			this.gerenciamentoToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem_Click);
			// 
			// professoresToolStripMenuItem
			// 
			this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoToolStripMenuItem1});
			this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
			this.professoresToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.professoresToolStripMenuItem.Text = "Professores";
			// 
			// gerenciamentoToolStripMenuItem1
			// 
			this.gerenciamentoToolStripMenuItem1.Name = "gerenciamentoToolStripMenuItem1";
			this.gerenciamentoToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
			this.gerenciamentoToolStripMenuItem1.Text = "Gerenciamento";
			this.gerenciamentoToolStripMenuItem1.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem1_Click);
			// 
			// turmasToolStripMenuItem
			// 
			this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem});
			this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
			this.turmasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.turmasToolStripMenuItem.Text = "Turmas";
			// 
			// visualizarToolStripMenuItem
			// 
			this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
			this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.visualizarToolStripMenuItem.Text = "Visualizar";
			// 
			// tb_manual
			// 
			this.tb_manual.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tb_manual.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_manual.Location = new System.Drawing.Point(107, 352);
			this.tb_manual.Name = "tb_manual";
			this.tb_manual.Size = new System.Drawing.Size(163, 27);
			this.tb_manual.TabIndex = 3;
			this.tb_manual.Text = "Manual de usuário";
			this.tb_manual.UseVisualStyleBackColor = true;
			this.tb_manual.Click += new System.EventHandler(this.tb_manual_Click);
			// 
			// pb_login
			// 
			this.pb_login.Image = global::WindowsFormsApp2.Properties.Resources.bvermelha;
			this.pb_login.Location = new System.Drawing.Point(12, 12);
			this.pb_login.Name = "pb_login";
			this.pb_login.Size = new System.Drawing.Size(25, 24);
			this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_login.TabIndex = 1;
			this.pb_login.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.a8d155aeccfaa3d984e908be3ca2c4bb;
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(377, 381);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// F_escola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 450);
			this.Controls.Add(this.tb_manual);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
		public System.Windows.Forms.PictureBox pb_login;
		public System.Windows.Forms.Label lb_user;
		public System.Windows.Forms.Label lb_nivel;
		private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button tb_manual;
	}
}

