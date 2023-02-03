namespace WindowsFormsApp2
{
	partial class GerenciamentoCurso
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lb_id = new System.Windows.Forms.Label();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bt_atualizar = new System.Windows.Forms.Button();
			this.bt_fechar = new System.Windows.Forms.Button();
			this.bt_excluir = new System.Windows.Forms.Button();
			this.cb_statusCurso = new System.Windows.Forms.ComboBox();
			this.bt_limpar = new System.Windows.Forms.Button();
			this.bt_cadastrar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_nomeCurso = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lb_nomecompleto = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_areaCurso = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_id
			// 
			this.lb_id.AutoSize = true;
			this.lb_id.Location = new System.Drawing.Point(56, 239);
			this.lb_id.Name = "lb_id";
			this.lb_id.Size = new System.Drawing.Size(18, 13);
			this.lb_id.TabIndex = 67;
			this.lb_id.Text = "ID";
			// 
			// tb_id
			// 
			this.tb_id.Location = new System.Drawing.Point(54, 255);
			this.tb_id.Name = "tb_id";
			this.tb_id.ReadOnly = true;
			this.tb_id.Size = new System.Drawing.Size(52, 20);
			this.tb_id.TabIndex = 66;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.Location = new System.Drawing.Point(447, 84);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ShowCellErrors = false;
			this.dataGridView1.ShowCellToolTips = false;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.ShowRowErrors = false;
			this.dataGridView1.Size = new System.Drawing.Size(340, 207);
			this.dataGridView1.TabIndex = 65;
			this.dataGridView1.TabStop = false;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// bt_atualizar
			// 
			this.bt_atualizar.Location = new System.Drawing.Point(196, 315);
			this.bt_atualizar.Name = "bt_atualizar";
			this.bt_atualizar.Size = new System.Drawing.Size(94, 27);
			this.bt_atualizar.TabIndex = 64;
			this.bt_atualizar.Text = "Atualizar";
			this.bt_atualizar.UseVisualStyleBackColor = true;
			this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
			// 
			// bt_fechar
			// 
			this.bt_fechar.Location = new System.Drawing.Point(636, 315);
			this.bt_fechar.Name = "bt_fechar";
			this.bt_fechar.Size = new System.Drawing.Size(94, 27);
			this.bt_fechar.TabIndex = 63;
			this.bt_fechar.Text = "Fechar";
			this.bt_fechar.UseVisualStyleBackColor = true;
			this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
			// 
			// bt_excluir
			// 
			this.bt_excluir.Location = new System.Drawing.Point(480, 315);
			this.bt_excluir.Name = "bt_excluir";
			this.bt_excluir.Size = new System.Drawing.Size(94, 27);
			this.bt_excluir.TabIndex = 62;
			this.bt_excluir.Text = "Excluir";
			this.bt_excluir.UseVisualStyleBackColor = true;
			this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
			// 
			// cb_statusCurso
			// 
			this.cb_statusCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_statusCurso.FormattingEnabled = true;
			this.cb_statusCurso.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
			this.cb_statusCurso.Location = new System.Drawing.Point(54, 198);
			this.cb_statusCurso.Name = "cb_statusCurso";
			this.cb_statusCurso.Size = new System.Drawing.Size(375, 21);
			this.cb_statusCurso.TabIndex = 61;
			this.cb_statusCurso.TabStop = false;
			this.cb_statusCurso.SelectedIndexChanged += new System.EventHandler(this.cb_statusCurso_SelectedIndexChanged);
			// 
			// bt_limpar
			// 
			this.bt_limpar.Location = new System.Drawing.Point(335, 315);
			this.bt_limpar.Name = "bt_limpar";
			this.bt_limpar.Size = new System.Drawing.Size(94, 27);
			this.bt_limpar.TabIndex = 60;
			this.bt_limpar.Text = "Limpar";
			this.bt_limpar.UseVisualStyleBackColor = true;
			this.bt_limpar.Click += new System.EventHandler(this.button2_Click);
			// 
			// bt_cadastrar
			// 
			this.bt_cadastrar.Location = new System.Drawing.Point(54, 315);
			this.bt_cadastrar.Name = "bt_cadastrar";
			this.bt_cadastrar.Size = new System.Drawing.Size(94, 27);
			this.bt_cadastrar.TabIndex = 59;
			this.bt_cadastrar.Text = "Cadastrar";
			this.bt_cadastrar.UseVisualStyleBackColor = true;
			this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 52;
			this.label2.Text = "Status Usuário";
			// 
			// tb_nomeCurso
			// 
			this.tb_nomeCurso.Location = new System.Drawing.Point(54, 84);
			this.tb_nomeCurso.Name = "tb_nomeCurso";
			this.tb_nomeCurso.Size = new System.Drawing.Size(375, 20);
			this.tb_nomeCurso.TabIndex = 49;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 47;
			this.label3.Text = "Área do curso";
			// 
			// lb_nomecompleto
			// 
			this.lb_nomecompleto.AutoSize = true;
			this.lb_nomecompleto.Location = new System.Drawing.Point(56, 68);
			this.lb_nomecompleto.Name = "lb_nomecompleto";
			this.lb_nomecompleto.Size = new System.Drawing.Size(79, 13);
			this.lb_nomecompleto.TabIndex = 46;
			this.lb_nomecompleto.Text = "Nome do curso";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(221, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(353, 31);
			this.label1.TabIndex = 45;
			this.label1.Text = "Gerenciamento de Cursos";
			// 
			// cb_areaCurso
			// 
			this.cb_areaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_areaCurso.FormattingEnabled = true;
			this.cb_areaCurso.Items.AddRange(new object[] {
            "Administração.",
            "Ciências Sociais.",
            "Comunicação e Mídia.",
            "Design e Arte.",
            "Direito.",
            "Educação.",
            "Engenharia e Arquitetura.",
            "Informação e Tecnologia."});
			this.cb_areaCurso.Location = new System.Drawing.Point(54, 139);
			this.cb_areaCurso.Name = "cb_areaCurso";
			this.cb_areaCurso.Size = new System.Drawing.Size(375, 21);
			this.cb_areaCurso.TabIndex = 68;
			// 
			// GerenciamentoCurso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 357);
			this.Controls.Add(this.cb_areaCurso);
			this.Controls.Add(this.lb_id);
			this.Controls.Add(this.tb_id);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bt_atualizar);
			this.Controls.Add(this.bt_fechar);
			this.Controls.Add(this.bt_excluir);
			this.Controls.Add(this.cb_statusCurso);
			this.Controls.Add(this.bt_limpar);
			this.Controls.Add(this.bt_cadastrar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_nomeCurso);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lb_nomecompleto);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "GerenciamentoCurso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GerenciamentoCurso";
			this.Load += new System.EventHandler(this.GerenciamentoCurso_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_id;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bt_atualizar;
		private System.Windows.Forms.Button bt_fechar;
		private System.Windows.Forms.Button bt_excluir;
		private System.Windows.Forms.ComboBox cb_statusCurso;
		private System.Windows.Forms.Button bt_limpar;
		private System.Windows.Forms.Button bt_cadastrar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_nomeCurso;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lb_nomecompleto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_areaCurso;
	}
}