using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Venda
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Venda> Select()
        {
            List<Model.Venda> lstVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from comanda_produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.id = Convert.ToInt32(reader["id"]);
                    venda.id_comanda = Convert.ToInt32(reader["id_comanda"]);
                    venda.id_produto = Convert.ToInt32(reader["id_produto"]);
                    venda.valor = reader["valor"].ToString();
                    lstVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Vendas nao localizadas");
            }
            finally
            {
                conexao.Close();
            }

            return lstVenda;
        }

        public List<Model.Venda> SelectById(int id_comanda)
        {
            List<Model.Venda> lstVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select comanda_produto.id, comanda_produto.id_comanda, comanda_produto.id_produto, produtos.descricao, comanda_produto.valor from comanda_produto inner join produtos on (produtos.id=comanda_produto.id_produto) where id_comanda=@id_comanda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_comanda", id_comanda);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.id = Convert.ToInt32(reader["id"]);
                    venda.id_comanda = Convert.ToInt32(reader["id_comanda"]);
                    venda.id_produto = Convert.ToInt32(reader["id_produto"]);
                    venda.descricao = reader["descricao"].ToString();
                    venda.valor = reader["valor"].ToString();
                    lstVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Vendas nao localizadas");
            }
            finally
            {
                conexao.Close();
            }

            return lstVenda;
        }

        public void Insert(Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into comanda_produto values ";
            sql = sql + " (@id_comanda, @id_produto, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_comanda", venda.id_comanda);
            cmd.Parameters.AddWithValue("@id_produto", venda.id_produto);
            cmd.Parameters.AddWithValue("@valor", venda.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar a Venda");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Delete from comanda_produto where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", venda.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro na remocao da comanda");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
