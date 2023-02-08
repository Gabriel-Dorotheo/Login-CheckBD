namespace WindowsFormsApp2
{
	partial class F_Turma
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
			this.cb_professor = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgv_turmas = new System.Windows.Forms.DataGridView();
			this.cb_ = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_status = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cb_horario = new System.Windows.Forms.ComboBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_professor
			// 
			this.cb_professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_professor.FormattingEnabled = true;
			this.cb_professor.Location = new System.Drawing.Point(12, 55);
			this.cb_professor.Name = "cb_professor";
			this.cb_professor.Size = new System.Drawing.Size(263, 21);
			this.cb_professor.TabIndex = 0;
			this.cb_professor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Professor";
			// 
			// dgv_turmas
			// 
			this.dgv_turmas.AllowUserToAddRows = false;
			this.dgv_turmas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_turmas.Location = new System.Drawing.Point(306, 12);
			this.dgv_turmas.Name = "dgv_turmas";
			this.dgv_turmas.ReadOnly = true;
			this.dgv_turmas.Size = new System.Drawing.Size(344, 332);
			this.dgv_turmas.TabIndex = 2;
			// 
			// cb_
			// 
			this.cb_.AutoSize = true;
			this.cb_.BackColor = System.Drawing.Color.Transparent;
			this.cb_.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_.Location = new System.Drawing.Point(8, 93);
			this.cb_.Name = "cb_";
			this.cb_.Size = new System.Drawing.Size(88, 19);
			this.cb_.TabIndex = 4;
			this.cb_.Text = "Capacidade";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(101, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Status";
			// 
			// cb_status
			// 
			this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_status.FormattingEnabled = true;
			this.cb_status.Location = new System.Drawing.Point(105, 124);
			this.cb_status.Name = "cb_status";
			this.cb_status.Size = new System.Drawing.Size(170, 21);
			this.cb_status.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Horário";
			// 
			// cb_horario
			// 
			this.cb_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_horario.FormattingEnabled = true;
			this.cb_horario.Location = new System.Drawing.Point(12, 183);
			this.cb_horario.Name = "cb_horario";
			this.cb_horario.Size = new System.Drawing.Size(170, 21);
			this.cb_horario.TabIndex = 7;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(12, 124);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ReadOnly = true;
			this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// F_Turma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.a8d155aeccfaa3d984e908be3ca2c4bb;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(665, 355);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cb_horario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cb_status);
			this.Controls.Add(this.cb_);
			this.Controls.Add(this.dgv_turmas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_professor);
			this.Name = "F_Turma";
			this.Text = "Gerenciar";
			this.Load += new System.EventHandler(this.F_Turma_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_professor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgv_turmas;
		private System.Windows.Forms.Label cb_;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cb_status;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_horario;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}