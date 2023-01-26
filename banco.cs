using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;


namespace WindowsFormsApp2
{
	internal class banco
	{
		private static SQLiteConnection conex;
		private static SQLiteConnection ConectarBanco()
		{
			//conex = new SQLiteConnection("Data Source=C:\\Users\\diogo.fsilva1\\source\\repos\\Projeto\\uc12Projeto\\bd\\bd_escola.db");
			//conex = new SQLiteConnection("Data Source=C:\\Users\\diogo.fsilva1\\source\\repos\\uc12Projeto\\bd\\bd_escola.db");
			//Definindo caminho relativo para o Bando de Dados
			conex = new SQLiteConnection("Data Source=" + Globais.caminhoDatabase);

			conex.Open();
			return conex;
		} // Fim do método ConectarBanco

		public static DataTable RelacaoUser()
		{

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();

			try
			{
				var vcon = ConectarBanco();
				var cmd = ConectarBanco().CreateCommand();
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

		// Metodo genérico para consultas no BD |  DQL - Data Query Language
		public static DataTable ConsultaSql(string sql)
		{

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();

			try
			{
				var vcon = ConectarBanco();
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


	



		public static void Dml(string sql, string msgOk = null, string msgErro = null) // Data Manipulation Language (INSERT - UPDADE - DELETE)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConectarBanco();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = sql;
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				//o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
				cmd.ExecuteNonQuery();
				vcon.Close();
				if (msgOk != null) { MessageBox.Show(msgOk); }


			}
			catch (Exception ex)
			{
				if (msgErro != null) { MessageBox.Show(msgErro + " " + ex.Message); }
				throw ex;
			}

		}

		// Fim das funções genéricas

		// Função para F_NovoUser Item 9.2 do Material de apoio

		public static void NovoUser(Usuario user)
		{

			if (UsernameExiste(user) == true)
			{

				MessageBox.Show("Usuário já existe no sistema ");
				return;

			}
			// Rotina para inserção do novo usuário no banco de dados
			try
			{
				var vcon = ConectarBanco();
				var cmd = vcon.CreateCommand();
				// Parâmetros conforme a tabela do banco de dados
				cmd.CommandText = "INSERT INTO tb_usuarios (nome_usuario,username_usuario,senha_usuario,status_usuario,nivel_usuario) VALUES (@nome,@username,@senha,@status,@nivel)";
				//cmd.CommandText = "INSERT INTO tb_usuarios  VALUES (null,'maria','maria','1234','A',2)";


				cmd.Parameters.AddWithValue("@nome", user.nome_usuario);
				cmd.Parameters.AddWithValue("@username", user.username_usuario);
				cmd.Parameters.AddWithValue("@senha", user.senha_usuario);
				cmd.Parameters.AddWithValue("@status", user.status_usuario);
				cmd.Parameters.AddWithValue("@nivel", user.nivel_usuario);

				cmd.ExecuteNonQuery();
				vcon.Close();
				MessageBox.Show("Novo usuário adicionado com sucesso");


			}
			catch (Exception ex)
			{


				MessageBox.Show("Erro ao inserir novo usuário .: " + ex.Message);
				//throw ex;

			}

		}// Fim do método NovoUser






		public static bool UsernameExiste(Usuario user)
		{
			bool resposta;
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();

			var vcon = ConectarBanco();
			var cmd = vcon.CreateCommand();
			cmd.CommandText = "SELECT username_usuario FROM tb_usuarios WHERE username_usuario='" + user.username_usuario + "'";
			da = new SQLiteDataAdapter(cmd.CommandText, vcon);
			//o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{

				resposta = true;

			}
			else
			{

				resposta = false;
			}
			vcon.Close();
			return resposta;

		} // Fim do método UsernameExiste


		// Fim do 9.2


		// Inicio 10.1 - F_GerenciamentoUser
		public static DataTable ObterUserID()
		{

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConectarBanco();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "SELECT id_usuario AS ID,nome_usuario AS Nome FROM tb_usuarios";
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				//o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
				da.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		// Fim 10.1

		// Início 10.2
		public static DataTable ObterDadosPorId(string id)
		{

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConectarBanco();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "SELECT * FROM tb_usuarios WHERE id_usuario=" + id;
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				//o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
				da.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		// Fim 10.2

		// Início 10.3

		public static void AtualizarUsuario(Usuario user)
		{

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConectarBanco();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "UPDATE tb_usuarios SET nome_usuario='" + user.nome_usuario + "',username_usuario='" + user.username_usuario + "',senha_usuario='" + user.senha_usuario + "',status_usuario='" + user.status_usuario + "',nivel_usuario=" + user.nivel_usuario + "'";
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				//o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
				cmd.ExecuteNonQuery();
				vcon.Close();

			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
		//Fim 10.3

		// Início 10.4

		public static void RemoverUsuario(string id)
		{

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConectarBanco();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "DELETE FROM tb_usuarios WHERE id_usuario=" + id;
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				//o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
				cmd.ExecuteNonQuery();
				vcon.Close();

			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
		//Fim 10.4

		public static void NovoCurso(Curso curso)
		{

			
			// Rotina para inserção do novo curso no banco de dados
			try
			{
				var vcon = ConectarBanco();
				var cmd = vcon.CreateCommand();
				// Parâmetros conforme a tabela do banco de dados
				cmd.CommandText = "INSERT INTO tb_curso (nome_curso,area_curso,status_curso) VALUES (@nome,@area,@senha)";
				//cmd.CommandText = "INSERT INTO tb_usuarios  VALUES (null,'maria','maria','1234','A',2)";


				cmd.Parameters.AddWithValue("@nome", curso.nome_curso);
				cmd.Parameters.AddWithValue("@area", curso.area_curso);
				cmd.Parameters.AddWithValue("@senha", curso.status_curso);
				

				cmd.ExecuteNonQuery();
				vcon.Close();
				MessageBox.Show("Novo usuário adicionado com sucesso");


			}
			catch (Exception ex)
			{


				MessageBox.Show("Erro ao inserir novo usuário .: " + ex.Message);
				//throw ex;

			}

		}// Fim do método NovoUser




	}
}

