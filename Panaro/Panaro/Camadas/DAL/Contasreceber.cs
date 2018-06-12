using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    class Contasreceber
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Contasreceber> Select()
        {
            List<Model.Contasreceber> lstConrec = new List<Model.Contasreceber>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from contasreceber;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Contasreceber contas = new Model.Contasreceber();
                    contas.id = Convert.ToInt32(reader["id"]);
                    contas.descricao = reader["descricao"].ToString();
                    contas.dataabert = reader["dataabert"].ToString();
                    contas.datavenc = reader["datavenc"].ToString();
                    contas.valor = reader["valor"].ToString();
                    contas.pago = reader["pago"].ToString();
                    lstConrec.Add(contas);
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

            return lstConrec;
        }

        public void Insert(Model.Contasreceber contas)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into contasreceber values ";
            sql = sql + " (@descricao, @dataabert, @datavenc, @valor, @pago);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", contas.descricao);
            cmd.Parameters.AddWithValue("@dataabert", contas.dataabert);
            cmd.Parameters.AddWithValue("@datavenc", contas.datavenc);
            cmd.Parameters.AddWithValue("@valor", contas.valor);
            cmd.Parameters.AddWithValue("@pago", contas.pago);
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

        public void Update(Model.Contasreceber contas)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Update contasreceber set valor=@valor, pago=@pago where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@valor", contas.valor);
            cmd.Parameters.AddWithValue("@pago", contas.pago);
            cmd.Parameters.AddWithValue("@id", contas.id);
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

        public void Delete(Model.Contasreceber contas)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Delete from contasreceber where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", contas.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro na remocao de cliente");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
