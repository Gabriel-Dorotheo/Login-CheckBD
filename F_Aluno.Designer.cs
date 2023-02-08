namespace WindowsFormsApp2
{
	partial class F_Aluno
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lb_id = new System.Windows.Forms.Label();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bt_atualizar = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.bt_excluir = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tb_cpf = new System.Windows.Forms.TextBox();
			this.tb_telefone = new System.Windows.Forms.TextBox();
			this.tb_nomeAluno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lb_nomecompleto = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_end = new System.Windows.Forms.TextBox();
			this.tb_endereco = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_id
			// 
			this.lb_id.AutoSize = true;
			this.lb_id.BackColor = System.Drawing.Color.Transparent;
			this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_id.Location = new System.Drawing.Point(296, 240);
			this.lb_id.Name = "lb_id";
			this.lb_id.Size = new System.Drawing.Size(20, 13);
			this.lb_id.TabIndex = 67;
			this.lb_id.Text = "ID";
			// 
			// tb_id
			// 
			this.tb_id.Location = new System.Drawing.Point(320, 237);
			this.tb_id.Name = "tb_id";
			this.tb_id.ReadOnly = true;
			this.tb_id.Size = new System.Drawing.Size(52, 20);
			this.tb_id.TabIndex = 66;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(389, 64);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ShowCellErrors = false;
			this.dataGridView1.ShowCellToolTips = false;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.ShowRowErrors = false;
			this.dataGridView1.Size = new System.Drawing.Size(301, 197);
			this.dataGridView1.TabIndex = 65;
			this.dataGridView1.TabStop = false;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// bt_atualizar
			// 
			this.bt_atualizar.Location = new System.Drawing.Point(196, 288);
			this.bt_atualizar.Name = "bt_atualizar";
			this.bt_atualizar.Size = new System.Drawing.Size(94, 27);
			this.bt_atualizar.TabIndex = 64;
			this.bt_atualizar.Text = "Atualizar";
			this.bt_atualizar.UseVisualStyleBackColor = true;
			this.bt_atualizar.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(596, 288);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(94, 27);
			this.button4.TabIndex = 63;
			this.button4.Text = "Fechar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// bt_excluir
			// 
			this.bt_excluir.Location = new System.Drawing.Point(458, 288);
			this.bt_excluir.Name = "bt_excluir";
			this.bt_excluir.Size = new System.Drawing.Size(94, 27);
			this.bt_excluir.TabIndex = 62;
			this.bt_excluir.Text = "Excluir";
			this.bt_excluir.UseVisualStyleBackColor = true;
			this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(325, 288);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 27);
			this.button2.TabIndex = 60;
			this.button2.Text = "Limpar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(58, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 27);
			this.button1.TabIndex = 59;
			this.button1.Text = "Cadastrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb_cpf
			// 
			this.tb_cpf.Location = new System.Drawing.Point(29, 157);
			this.tb_cpf.Name = "tb_cpf";
			this.tb_cpf.Size = new System.Drawing.Size(343, 20);
			this.tb_cpf.TabIndex = 51;
			// 
			// tb_telefone
			// 
			this.tb_telefone.Location = new System.Drawing.Point(29, 110);
			this.tb_telefone.Name = "tb_telefone";
			this.tb_telefone.Size = new System.Drawing.Size(343, 20);
			this.tb_telefone.TabIndex = 50;
			// 
			// tb_nomeAluno
			// 
			this.tb_nomeAluno.Location = new System.Drawing.Point(29, 64);
			this.tb_nomeAluno.Name = "tb_nomeAluno";
			this.tb_nomeAluno.Size = new System.Drawing.Size(343, 20);
			this.tb_nomeAluno.TabIndex = 49;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 19);
			this.label4.TabIndex = 48;
			this.label4.Text = "CPF";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 19);
			this.label3.TabIndex = 47;
			this.label3.Text = "Telefone";
			// 
			// lb_nomecompleto
			// 
			this.lb_nomecompleto.AutoSize = true;
			this.lb_nomecompleto.BackColor = System.Drawing.Color.Transparent;
			this.lb_nomecompleto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nomecompleto.Location = new System.Drawing.Point(25, 42);
			this.lb_nomecompleto.Name = "lb_nomecompleto";
			this.lb_nomecompleto.Size = new System.Drawing.Size(118, 19);
			this.lb_nomecompleto.TabIndex = 46;
			this.lb_nomecompleto.Text = "Nome completo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(28, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(334, 31);
			this.label1.TabIndex = 45;
			this.label1.Text = "Gerenciamento de Aluno";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tb_end
			// 
			this.tb_end.Location = new System.Drawing.Point(29, 202);
			this.tb_end.Name = "tb_end";
			this.tb_end.Size = new System.Drawing.Size(343, 20);
			this.tb_end.TabIndex = 69;
			// 
			// tb_endereco
			// 
			this.tb_endereco.AutoSize = true;
			this.tb_endereco.BackColor = System.Drawing.Color.Transparent;
			this.tb_endereco.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_endereco.Location = new System.Drawing.Point(25, 180);
			this.tb_endereco.Name = "tb_endereco";
			this.tb_endereco.Size = new System.Drawing.Size(71, 19);
			this.tb_endereco.TabIndex = 68;
			this.tb_endereco.Text = "Endereço";
			// 
			// F_Aluno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.a8d155aeccfaa3d984e908be3ca2c4bb;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(720, 333);
			this.Controls.Add(this.tb_end);
			this.Controls.Add(this.tb_endereco);
			this.Controls.Add(this.lb_id);
			this.Controls.Add(this.tb_id);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bt_atualizar);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.bt_excluir);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_cpf);
			this.Controls.Add(this.tb_telefone);
			this.Controls.Add(this.tb_nomeAluno);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lb_nomecompleto);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "F_Aluno";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerenciar";
			this.Load += new System.EventHandler(this.F_Aluno_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_id;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bt_atualizar;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button bt_excluir;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tb_cpf;
		private System.Windows.Forms.TextBox tb_telefone;
		private System.Windows.Forms.TextBox tb_nomeAluno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lb_nomecompleto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_end;
		private System.Windows.Forms.Label tb_endereco;
	}
}