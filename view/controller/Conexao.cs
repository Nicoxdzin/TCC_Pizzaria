using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;//biblioteca de conexao mysql
using System.Security;

namespace ProjetoTCC
{
    class Conexao
    {

        //variaveis de conexao
        static private string servidor = "localhost";//caminho do servidor
        static private string bancodedados = "db_teste";//nome do bd
        static private string usuario = "root";//nome do usuario hostgator
        static private string senha = "";//Senha do bd

        static public string StrCon = "server=" + servidor + ";database=" +
            bancodedados + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection getConexao()
        {
            MySqlConnection conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                getConexao().Open();//abrir a conexao bd
                result = true;
            }
            catch (Exception ex)
            {
                result = false;  
                throw new Exception(ex.Message);
            }
            return result;//retorna a conexao

        }
        public void desconectar()
        {
            getConexao().Close();
        }
        public DataTable Getperfil()
        {
            MySqlConnection conexao = getConexao();
            string SQL = "SELECT * FROM perfil";
            DataTable dtPerfil = new DataTable();
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                MySqlDataAdapter dados = new MySqlDataAdapter(comando);

                dados.Fill(dtPerfil);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dtPerfil;
        }
    }
}