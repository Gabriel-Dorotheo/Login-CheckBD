namespace WindowsFormsApp2
{
	partial class F_criarconta
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
			this.label1 = new System.Windows.Forms.Label();
			this.lb_nomecompleto = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_nomeCompleto = new System.Windows.Forms.TextBox();
			this.tb_usename = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(105, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Novo usuário";
			// 
			// lb_nomecompleto
			// 
			this.lb_nomecompleto.AutoSize = true;
			this.lb_nomecompleto.Location = new System.Drawing.Point(17, 60);
			this.lb_nomecompleto.Name = "lb_nomecompleto";
			this.lb_nomecompleto.Size = new System.Drawing.Size(81, 13);
			this.lb_nomecompleto.TabIndex = 1;
			this.lb_nomecompleto.Text = "Nome completo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Username (apelido)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// tb_nomeCompleto
			// 
			this.tb_nomeCompleto.Location = new System.Drawing.Point(15, 76);
			this.tb_nomeCompleto.Name = "tb_nomeCompleto";
			this.tb_nomeCompleto.Size = new System.Drawing.Size(375, 20);
			this.tb_nomeCompleto.TabIndex = 4;
			this.tb_nomeCompleto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tb_usename
			// 
			this.tb_usename.Location = new System.Drawing.Point(15, 131);
			this.tb_usename.Name = "tb_usename";
			this.tb_usename.Size = new System.Drawing.Size(375, 20);
			this.tb_usename.TabIndex = 5;
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(15, 186);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(375, 20);
			this.tb_password.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Status Usuário";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 292);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Nível de acesso";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(15, 308);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(20, 255);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(61, 17);
			this.radioButton1.TabIndex = 10;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Ativado";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(111, 255);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(79, 17);
			this.radioButton2.TabIndex = 11;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Desativado";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 341);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "1 - Aluno";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(103, 341);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "2 - Inspetor";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(207, 341);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "3 - Professor";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(302, 341);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "4 - Coordenador";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(84, 398);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 27);
			this.button1.TabIndex = 16;
			this.button1.Text = "Cadastrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(210, 398);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 27);
			this.button2.TabIndex = 17;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// F_criarconta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 437);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.tb_usename);
			this.Controls.Add(this.tb_nomeCompleto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lb_nomecompleto);
			this.Controls.Add(this.label1);
			this.Name = "F_criarconta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "F_criarconta";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lb_nomecompleto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_nomeCompleto;
		private System.Windows.Forms.TextBox tb_usename;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}