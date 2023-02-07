using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class F_escola : Form
    {
        public F_escola()
        {
            InitializeComponent();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
			if (Globais.logado)
			{
				tb_manual.Visible = false;
			}
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Globais.logado)
			{
				if (Globais.nivel >= 3)
				{
					F_criarconta f_criarconta = new F_criarconta();
					f_criarconta.ShowDialog();

				}
				else
				{
					MessageBox.Show("Nível de acesso não permitido!");
				}
			}
			else
			{
				MessageBox.Show("É necessário logar no sistema...");
			}

		}

		private void novoCursoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Globais.logado)
			{
				if(Globais.nivel >= 3)
				{
					F_novocurso f_novocurso = new F_novocurso();
					f_novocurso.ShowDialog();

				}
				else
				{
					MessageBox.Show("Nível de acesso não permitido!");
				}
			}
			else
			{
				MessageBox.Show("É necessário logar no sistema.");
			}
		}

		private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Globais.logado)
			{
				if (Globais.nivel >= 3 )
				{
					F_GerenciamentoUser gerenciamento = new F_GerenciamentoUser();
					gerenciamento.ShowDialog();

				}
				else
				{
					MessageBox.Show("Nível de acesso não permitido!");
				}
			}
			else
			{
				MessageBox.Show("É necessário logar no sistema.");
			}
		}

		private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Globais.logado)
			{
				if (MessageBox.Show("Tem certeza que deseja sair? ", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					lb_nivel.Text = "--";
					lb_user.Text = "--";
					pb_login.Image = Properties.Resources.bvermelha;
					tb_manual.Visible = true;
				}

			}
			else
			{
				MessageBox.Show("É necessário logar no sistema.");
			}
		}

		private void gerenciamentoToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (Globais.logado)
			{
				if (Globais.nivel >= 3)
				{
					F_Professor gerenciar_professor = new F_Professor();
					gerenciar_professor.ShowDialog();

				}
				else
				{
					MessageBox.Show("Nível de acesso não permitido!");
				}
			}
			else
			{
				MessageBox.Show("É necessário logar no sistema.");
			}
		}

		private void gerenciamentoToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			if (Globais.logado)
			{
				if (Globais.nivel >= 3)
				{
					F_Aluno gerenciamento_alunos = new F_Aluno();
					gerenciamento_alunos.ShowDialog();

				}
				else
				{
					MessageBox.Show("Nível de acesso não permitido!");
				}
			}
			else
			{
				MessageBox.Show("É necessário logar no sistema.");
			}
		}

		private void gerenciamentoToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (Globais.logado)
			{
				if (Globais.nivel >= 3)
				{
					GerenciamentoCurso gerenciarCurso = new GerenciamentoCurso();
					gerenciarCurso.ShowDialog();

				}
				else
				{
					MessageBox.Show("Nível de acesso não permitido!");
				}
			}
			else
			{
				MessageBox.Show("É necessário logar no sistema.");
			}
		}

		private void manualDoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void tb_manual_Click(object sender, EventArgs e)
		{
			F_Manual manual = new F_Manual();
			manual.ShowDialog();
		}
	}
}
