using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
	public partial class F_Professor : Form
	{
		public F_Professor()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Professor professor = new Professor();
			professor.nome_professor = tb_nomeProfessor.Text;
			banco.NovoProfessor(professor);
			dataGridView1.DataSource = banco.ObterUserIDProfessor();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tb_nomeProfessor.Text = "";
			tb_id.Text = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bt_excluir_Click(object sender, EventArgs e)
		{
			DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Usuário", MessageBoxButtons.YesNo);
			if (resposta == DialogResult.Yes)
			{
				banco.RemoverProfessor(tb_id.Text);
				dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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
				dt = banco.ObterDadosProfessor(userId);
				tb_id.Text = dt.Rows[0].Field<Int64>("id_professor").ToString();
				tb_nomeProfessor.Text = dt.Rows[0].Field<string>("nome_professor").ToString();


			}
		}

		private void F_Professor_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = banco.ObterUserIDProfessor();
			// Define a largura das colunas do DataGridView usuário
			dataGridView1.Columns[0].Width = 40;
			dataGridView1.Columns[1].Width = 362;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int linha = dataGridView1.SelectedRows[0].Index;


			Professor prof = new Professor();
			prof.id_professor = Convert.ToInt32(tb_id.Text);
			prof.nome_professor = tb_nomeProfessor.Text;

			banco.AtualizarProfessor(prof);
			dataGridView1[1, linha].Value = tb_nomeProfessor.Text;
		}
	}
}
