using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Contaspagar
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Contaspagar> Select()
        {
            List<Model.Contaspagar> lstContaspagar = new List<Model.Contaspagar>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from contaspagar;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Contaspagar contaspagar = new Model.Contaspagar();
                    contaspagar.id = Convert.ToInt32(reader["id"]);
                    contaspagar.descricao = reader["descricao"].ToString();
                    contaspagar.data = reader["data"].ToString();
                    contaspagar.valor = reader["valor"].ToString();
                    contaspagar.pago = reader["pago"].ToString();
                    lstContaspagar.Add(contaspagar);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Contas nao localizadas");
            }
            finally
            {
                conexao.Close();
            }

            return lstContaspagar;
        }

        public List<Model.Contaspagar> SelectById(int id)
        {
            List<Model.Contaspagar> lstContaspagar = new List<Model.Contaspagar>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from contaspagar where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Contaspagar contaspagar = new Model.Contaspagar();
                    contaspagar.id = Convert.ToInt32(reader["id"]);
                    contaspagar.descricao = reader["descricao"].ToString();
                    contaspagar.data = reader["data"].ToString();
                    contaspagar.valor = reader["valor"].ToString();
                    contaspagar.pago = reader["pago"].ToString();
                    lstContaspagar.Add(contaspagar);
                }
            }
            catch
            {
                Console.WriteLine("Erro - conta nao localizada");
            }
            finally
            {
                conexao.Close();
            }

            return lstContaspagar;
        }

        public List<Model.Contaspagar> SelectByDesc(string descricao)
        {
            List<Model.Contaspagar> lstContaspagar = new List<Model.Contaspagar>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from contaspagar where (descricao like @descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", descricao.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Contaspagar contaspagar = new Model.Contaspagar();
                    contaspagar.id = Convert.ToInt32(reader["id"]);
                    contaspagar.descricao = reader["descricao"].ToString();
                    contaspagar.data = reader["data"].ToString();
                    contaspagar.valor = reader["valor"].ToString();
                    contaspagar.pago = reader["pago"].ToString();
                    lstContaspagar.Add(contaspagar);
                }
            }
            catch
            {
                Console.WriteLine("Erro - conta nao localizada");
            }
            finally
            {
                conexao.Close();
            }

            return lstContaspagar;
        }

        public void Insert(Model.Contaspagar contaspagar)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into contaspagar values ";
            sql = sql + " (@descricao, @data, @valor, @pago);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", contaspagar.descricao);
            cmd.Parameters.AddWithValue("@data", contaspagar.data);
            cmd.Parameters.AddWithValue("@valor", contaspagar.valor);
            cmd.Parameters.AddWithValue("@pago", contaspagar.pago);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar a conta");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Update(Model.Contaspagar contaspagar)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Update contaspagar set descricao=@descricao, data=@data, valor=@valor, pago=@pago where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", contaspagar.descricao);
            cmd.Parameters.AddWithValue("@data", contaspagar.data);
            cmd.Parameters.AddWithValue("@valor", contaspagar.valor);
            cmd.Parameters.AddWithValue("@pago", contaspagar.pago);
            cmd.Parameters.AddWithValue("@id", contaspagar.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualizacao de contas");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Contaspagar contaspagar)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Delete from contaspagar where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", contaspagar.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro na remocao de contas");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
