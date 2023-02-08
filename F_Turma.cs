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

namespace WindowsFormsApp2
{
	public partial class F_Turma : Form
	{
		public F_Turma()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void F_Turma_Load(object sender, EventArgs e)
		{
			string sql = @"
                    SELECT 
                           tt.id_turma AS Id,
                           tt.desc_turma  AS Turma,
                           th.descricao_horario AS Horário
                       FROM
                         tb_turmas as tt
                       INNER JOIN  tb_horarios as th on th.id_horario = tt.id_horario_turma
                      
                     ";
			dgv_turmas.DataSource = banco.Dql(sql);
			dgv_turmas.Columns[0].Width = 35;
			dgv_turmas.Columns[0].Width = 80;
			dgv_turmas.Columns[0].Width = 100;



			// Popular ComboBox
			string sqlProf = @"
                            SELECT
                                    id_professor,
                                    nome_professor
                                FROM
                                    tb_professor
                                    ORDER BY
                                    id_professor                                
                        
                    ";
			cb_professor.Items.Clear();
			cb_professor.DataSource = banco.Dql(sqlProf);
			cb_professor.DisplayMember = "nome_professor";
			cb_professor.ValueMember = "id_professor";

			//Popular ComboBox Status
			Dictionary<string, string> status = new Dictionary<string, string>();
			status.Add("A", "Ativa");
			status.Add("F", "Finalizada");
			status.Add("I", "Inscrição");
			cb_status.Items.Clear();
			cb_status.DataSource = new BindingSource(status, null);
			cb_status.DisplayMember = "Value";
			cb_status.ValueMember = "Key";



			// Popular ComboBoxHorarios
			string sqlHorario = @"
                            SELECT
                                    *
                                FROM
                                    tb_horarios
                                    ORDER BY
                                    descricao_horario                              
                        
                    ";
			cb_horario.Items.Clear();
			cb_horario.DataSource = banco.Dql(sqlHorario);
			cb_horario.DisplayMember = "descricao_horario";
			cb_horario.ValueMember = "id_horario";
		}
	}
}
