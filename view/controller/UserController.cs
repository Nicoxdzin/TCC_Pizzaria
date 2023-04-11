using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoTCC;

namespace Controller
{
    internal class UserController
    {
        Conexao conn = new Conexao();

        public UserController() {
            
        }

        public void Entrar()
        {

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
