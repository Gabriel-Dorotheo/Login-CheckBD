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
	public partial class F_Aluno : Form
	{
		public F_Aluno()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Aluno novoAluno = new Aluno();
			novoAluno.nome_aluno = tb_nomeAluno.Text;
			novoAluno.telefone_aluno = tb_telefone.Text;
			novoAluno.cpf_aluno = tb_cpf.Text;
			novoAluno.endereco_aluno = tb_end.Text;
			banco.NovoAluno(novoAluno); 
			dataGridView1.DataSource = banco.ObterAlunoID();


		}

		private void button2_Click(object sender, EventArgs e)
		{
			tb_nomeAluno.Text = "";
			tb_telefone.Text = "";
			tb_cpf.Text = "";
			tb_end.Text = "";
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
				banco.RemoverAluno(tb_id.Text);
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
			int qtdLinhas = dgv.SelectedRows.Count;
			//Realize o procedimento caso tenha ao menos uma linha selecionada
			if (qtdLinhas > 0)
			{
				// Quando obtiver os dados do banco de datos precisaremos de algo para guardar com um DataTable
				DataTable dt = new DataTable();                 //O dado da coluna índice 0 é o Id do usuário
				string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
				dt = banco.ObterDadosPorAluno(userId);
				tb_id.Text = dt.Rows[0].Field<Int64>("id_aluno").ToString();
				tb_nomeAluno.Text = dt.Rows[0].Field<string>("nome_aluno").ToString();
				tb_telefone.Text = dt.Rows[0].Field<string>("telefone_aluno").ToString();
				tb_cpf.Text = dt.Rows[0].Field<string>("cpf_aluno").ToString();
				tb_end.Text = dt.Rows[0].Field<string>("endereco_aluno").ToString();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int linha = dataGridView1.SelectedRows[0].Index;


			Aluno novo = new Aluno();
			novo.id_aluno = Convert.ToInt32(tb_id.Text);
			novo.nome_aluno = tb_nomeAluno.Text;
			novo.endereco_aluno = tb_end.Text;

			banco.AtualizarAluno(novo);
			dataGridView1[1, linha].Value = tb_nomeAluno.Text;
		}

		private void F_Aluno_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = banco.ObterAlunoID();
			// Define a largura das colunas do DataGridView usuário
			dataGridView1.Columns[0].Width = 40;
			dataGridView1.Columns[1].Width = 150;
			dataGridView1.Columns[2].Width = 108;

		}
	}
}
