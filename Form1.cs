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
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			F_criarconta f_criarconta = new F_criarconta();
			f_criarconta.ShowDialog();

		}

		private void novoCursoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			F_novocurso f_novocurso = new F_novocurso();
			f_novocurso.ShowDialog();
		}
	}
}
