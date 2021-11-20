using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1LucasPereira24.Code.DAL
{
    class AcessoBancoDados
    {

        MySqlConnection conexao;

        public void Conectar()
        {

            try
            {
                string conn = "Persist Security Info = false;" +
                              "server = localhost; " +
                              "database = dblojasrede; " +
                              "uid = root; pwd=root";

                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Nao foi possivel conectar ao banco de dados.\n" + ex.Message);
            }









        }

        internal DataTable ExecutarConsulta(string sql)
        {
            throw new NotImplementedException();
        }

        internal void ExecutarComando(string inserir)
        {
            throw new NotImplementedException();
        }

        internal DataTable ExecutarGerenciamento(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
