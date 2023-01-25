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
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class F_login : Form
    {
        F_escola f_login;
        DataTable dt = new DataTable();
        public F_login( F_escola f)
        {
            InitializeComponent();
            f_login = f;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string senha = tb_senha.Text;
            if (username == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                tb_user.Focus();
                return;
            }
			string sql = "SELECT * FROM tb_usuarios WHERE username_usuario='" + username + "'AND senha_usuario='" + senha + "'";
            dt = Database.ConsultaSql(sql);
            if(dt.Rows.Count == 1)
            {
                f_login.lb_nivel.Text = dt.Rows[0].ItemArray[5].ToString();
                f_login.lb_user.Text = dt.Rows[0].Field<string>("nome_usuario");
                f_login.pb_login.Image = Resources.bverde;
                Globais.logado = true;
                this.Close();
            }



		}

        
    }
}
