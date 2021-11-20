using _3C1LucasPereira24.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3C1LucasPereira24.Code.DAL;
using System.Data;

namespace _3C1LucasPereira24.Code.BLL
{
    class RedeBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_produto";


        public void Inserir(RedeDTO reddto)
        {

            string inserir = $"insert into {tabela} values(null,'{reddto.Produto}','{reddto.Preco}')";
            conexao.ExecutarComando(inserir);

        }


        public void Editar(RedeDTO reddto)
        {
            string alterar = $"update {tabela} set produtos = 'reddto.Produtos', preco = '{reddto.Produto}' where id = '{reddto.Id}';";
            conexao.ExecutarComando(alterar);



        }

        public void Excluir(RedeDTO reddto)
        {
            string excluir = $"delete from {tabela} where id = '{reddto.Id}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarGerenciamento(sql);
        }




    }
}
