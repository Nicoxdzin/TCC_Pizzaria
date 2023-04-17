using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controller1
{
    public class Conexao
    {
        //variaveis de conexao
        static private string servidor = "localhost";//caminho do servidor
        static private string bancodedados = "bd_teste";//nome do bd
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
                Exception exception= ex;
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
            catch (MySqlException ex)
            {
                Exception exception = ex;   
            }
            finally
            {
                conexao.Close();
            }
            return dtPerfil;
        }
    }
}
