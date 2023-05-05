using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller1
{
    public class Conexao
    {
        //variaveis de conexao
        static private string servidor = "localhost";//caminho do servidor
        static private string bancodedados = "bd_teste";//nome do bd
        static private string usuario = "root";//nome do usuario hostgator
        static private string senha = "";//Senha do bd

        static public string StrCon = @"Data Source=SNCTP06LABF06\SQLEXPRESS;Initial Catalog = db_tcc; Integrated Security = True";
        public SqlConnection getConexao()
        {
            SqlConnection conn = new SqlConnection(StrCon);
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
                Exception exception = ex;
            }
            return result;//retorna a conexao

        }
        public void desconectar()
        {
            getConexao().Close();
        }
        public DataTable Getperfil()
        {
            SqlConnection conexao = getConexao();
            string SQL = "SELECT * FROM perfil";
            DataTable dtPerfil = new DataTable();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataAdapter dados = new SqlDataAdapter(comando);
                dados.Fill(dtPerfil);


            }
            catch (SqlException ex)
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