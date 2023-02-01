using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp2
{
	public partial class F_criarconta : Form
	{
	DataTable dt = new DataTable();
		public F_criarconta()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario();
			usuario.nome_usuario = tb_nomeCompleto.Text;
			usuario.username_usuario = tb_usename.Text;
			usuario.senha_usuario = tb_password.Text;
			usuario.status_usuario = comboBox1.Text;
			usuario.nivel_usuario = int.Parse(numericUpDown1.Text);
			banco.NovoUser(usuario);
			this.Close();
		}


	}
}
