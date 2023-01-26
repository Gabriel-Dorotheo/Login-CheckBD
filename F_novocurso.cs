using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
	public partial class F_novocurso : Form
	{
		DataTable dt = new DataTable();
		public F_novocurso()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			// Botao cadastrar


			Curso curso= new Curso();
			curso.nome_curso = textBox1.Text;
			curso.status_curso = textBox2.Text;
			curso.area_curso = textBox3.Text;

			banco.NovoCurso(curso);
			
			
			
			
			
			
			
			string nomecurso = textBox1.Text;
			if (nomecurso == "")
			{
				MessageBox.Show("Preencha todos os campos!");
				textBox1.Focus();
				return;
			}
			string cursos = "SELECT * FROM tb_curso WHERE nome_curso='"+nomecurso+"'";
			dt = Database.ConsultaSql(cursos);
			if(dt.Rows.Count == 1)
			{
				MessageBox.Show("Curso já existente.");
			}
		}
	}
}
