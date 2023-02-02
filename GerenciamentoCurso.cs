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
	public partial class GerenciamentoCurso : Form
	{
		public GerenciamentoCurso()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Curso curso = new Curso();
			curso.nome_curso = tb_nomeCurso.Text;
			curso.area_curso = cb_areaCurso.Text;
			curso.status_curso = cb_statusCurso.Text;
			banco.NovoCurso(curso);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tb_nomeCurso.Text = "";
			cb_areaCurso.Text = "";
			cb_statusCurso.Text = "";
		}

		private void cb_statusCurso_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		private void bt_fechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.DataSource = banco.ObterUserID();
			// Define a largura das colunas do DataGridView usuário
			dataGridView1.Columns[0].Width = 40;
			dataGridView1.Columns[1].Width = 258;
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
				dt = banco.ObterDadosCurso(userId);
				tb_id.Text = dt.Rows[0].Field<Int64>("id_curso").ToString();
				tb_nomeCurso.Text = dt.Rows[0].Field<string>("nome_curso").ToString();
				cb_areaCurso.Text = dt.Rows[0].Field<string>("area_curso").ToString();
				cb_statusCurso.Text = dt.Rows[0].Field<string>("status_curso").ToString();
			}
		}

		private void bt_atualizar_Click(object sender, EventArgs e)
		{
			int linha = dataGridView1.SelectedRows[0].Index;


			Curso curs = new Curso();
			curs.id_curso = Convert.ToInt32(tb_id.Text);
			curs.nome_curso = tb_nomeCurso.Text;

			banco.AtualizarCurso(curs);
			dataGridView1[1, linha].Value = tb_nomeCurso.Text;
		}

		private void GerenciamentoCurso_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = banco.ObterUserIDCurso();
			// Define a largura das colunas do DataGridView usuário
			dataGridView1.Columns[0].Width = 40;
			dataGridView1.Columns[1].Width = 297;
		}

		private void bt_excluir_Click(object sender, EventArgs e)
		{
			DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Usuário", MessageBoxButtons.YesNo);
			if (resposta == DialogResult.Yes)
			{
				banco.RemoverCurso(tb_id.Text);
				dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			}
		}
	}
}
