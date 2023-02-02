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

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			// Botao cadastrar


			Curso curso= new Curso();
			curso.nome_curso = textBox1.Text;
			curso.area_curso = textBox2.Text;
			curso.status_curso = cb_statusCurso.Text;
			banco.NovoCurso(curso);
		}

		private void F_novocurso_Load(object sender, EventArgs e)
		{

		}
	}
}
