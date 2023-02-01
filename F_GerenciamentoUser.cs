using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp2
{
	public partial class F_GerenciamentoUser : Form
	{
		public F_GerenciamentoUser()
		{
			InitializeComponent();
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
		}
		private void F_GerenciamentoUser_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = banco.ObterUserID();
			// Define a largura das colunas do DataGridView usuário
			dataGridView1.Columns[0].Width = 40;
			dataGridView1.Columns[1].Width = 180;
		}


		private void button2_Click(object sender, EventArgs e)
		{
			tb_nomeCompleto.Text = "";
			tb_usename.Text = "";
			tb_password.Text = "";
			comboBox1.Text = "Ativado";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Usuário", MessageBoxButtons.YesNo);
			if (resposta == DialogResult.Yes)
			{
				banco.RemoverUsuario(tb_id.Text);
				dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}

		private void tb_id_TextChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			int linha = dataGridView1.SelectedRows[0].Index;


			Usuario user = new Usuario();
			user.id_usuario = Convert.ToInt32(tb_id.Text);
			user.nome_usuario = tb_nomeCompleto.Text;
			user.username_usuario = tb_usename.Text;
			user.senha_usuario = tb_password.Text;
			user.status_usuario = comboBox1.Text;
			user.nivel_usuario = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));

			banco.AtualizarUsuario(user);
			dataGridView1[1, linha].Value = tb_nomeCompleto.Text;


		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			// evento de linha selecionada
			DataGridView dgv = sender as DataGridView;
			int qtdLinhas = dgv.SelectedRows. Count;
			//Realize o procedimento caso tenha ao menos uma linha selecionada
			if (qtdLinhas > 0)
			{
				// Quando obtiver os dados do banco de datos precisaremos de algo para guardar com um DataTable
				DataTable dt = new DataTable();                 //O dado da coluna índice 0 é o Id do usuário
				string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
				dt = banco.ObterDadosPorId(userId); 
				tb_id.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
				tb_nomeCompleto.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
				tb_usename.Text = dt.Rows[0].Field<string>("username_usuario").ToString();
				tb_password.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
				comboBox1.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
				numericUpDown1.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();

			}
		}
	}
}
