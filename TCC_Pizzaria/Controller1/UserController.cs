using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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
            MySqlConnection conexao = conn.getConexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@usuario", usu.usuario);
            comando.Parameters.AddWithValue("@senha", usu.senha);
            MySqlDataReader registro = comando.ExecuteReader();//executa a consulta
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
            MySqlConnection conexao = conn.getConexao();
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
