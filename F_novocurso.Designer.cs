namespace WindowsFormsApp2
{
	partial class F_novocurso
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
			this.lb_nomecurso = new System.Windows.Forms.Label();
			this.lb_areacurso = new System.Windows.Forms.Label();
			this.lb_statuscurso = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_nomecurso
			// 
			this.lb_nomecurso.AutoSize = true;
			this.lb_nomecurso.Location = new System.Drawing.Point(12, 45);
			this.lb_nomecurso.Name = "lb_nomecurso";
			this.lb_nomecurso.Size = new System.Drawing.Size(79, 13);
			this.lb_nomecurso.TabIndex = 0;
			this.lb_nomecurso.Text = "Nome do curso";
			// 
			// lb_areacurso
			// 
			this.lb_areacurso.AutoSize = true;
			this.lb_areacurso.Location = new System.Drawing.Point(12, 100);
			this.lb_areacurso.Name = "lb_areacurso";
			this.lb_areacurso.Size = new System.Drawing.Size(73, 13);
			this.lb_areacurso.TabIndex = 1;
			this.lb_areacurso.Text = "Área do curso";
			// 
			// lb_statuscurso
			// 
			this.lb_statuscurso.AutoSize = true;
			this.lb_statuscurso.Location = new System.Drawing.Point(12, 155);
			this.lb_statuscurso.Name = "lb_statuscurso";
			this.lb_statuscurso.Size = new System.Drawing.Size(81, 13);
			this.lb_statuscurso.TabIndex = 2;
			this.lb_statuscurso.Text = "Status do curso";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 241);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Limpar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(142, 241);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Adicionar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(277, 241);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Cancelar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 61);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(340, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "Assistente tecnico";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 116);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(340, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.Text = "computacao";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 171);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(340, 20);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "A";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(107, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 31);
			this.label1.TabIndex = 10;
			this.label1.Text = "Novo curso";
			// 
			// F_novocurso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 287);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lb_statuscurso);
			this.Controls.Add(this.lb_areacurso);
			this.Controls.Add(this.lb_nomecurso);
			this.Name = "F_novocurso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_nomecurso;
		private System.Windows.Forms.Label lb_areacurso;
		private System.Windows.Forms.Label lb_statuscurso;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
	}
}