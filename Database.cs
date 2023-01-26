using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using WindowsFormsApp2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    internal class Database
    {
        private static SQLiteConnection conex;
        private static SQLiteConnection ConectarDatabase()
        {
            conex = new SQLiteConnection("Data Source=" + Globais.caminhoDatabase);

            conex.Open();
            return conex;
        }
        // Fim do método ConectarDatabase


        public static DataTable RelacaoUser()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = ConectarDatabase().CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método genérico para consulta no BD | DQL - Data Query Language
        public static DataTable ConsultaSql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Dml(string sql, string msgOk = null, string msgErro = null)
        // Data Manipulation Language (INSERT - UPDADE - DELETE)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                // O Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
                cmd.ExecuteNonQuery();
                vcon.Close();

                if (msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }
            }
            catch (Exception ex)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + " " + ex.Message);
                }
                throw ex;
            }
        }



	

















	}
}
