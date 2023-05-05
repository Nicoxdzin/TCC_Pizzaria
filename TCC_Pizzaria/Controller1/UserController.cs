using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controller1;
using model1;

namespace Controller
{
    public class UserController
    {
        Conexao conn = new Conexao();

        public UserController() {
            
        }

        public Usuario Entrar(Usuario usu )
        {
            String logar = "SELECT * FROM tb_usuario WHERE usuario=@usuario AND senha=@senha";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@usuario", usu.usuario);
            comando.Parameters.AddWithValue("@senha", usu.senha);
            SqlDataReader registro = comando.ExecuteReader();//executa a consulta
            if (registro.HasRows)
            {
                registro.Read();
                usu.usuario = Convert.ToString(registro["usuario"]);
                usu.senha = Convert.ToString(registro["senha"]);
                usu.perfil = Convert.ToInt16(registro["perfil"]);
                usu.logado = true;


            }
            return usu;
        }

        public void Cadastrar()
        {

        }

        public void Editar()
        {

        }
        public void Listar()
        {

        }

        public DataTable Getperfil()
        {
            SqlConnection conexao = conn.getConexao();
            string SQL = "SELECT * FROM perfil";
            DataTable dtPerfil = new DataTable();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataAdapter dados = new SqlDataAdapter(comando);

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
