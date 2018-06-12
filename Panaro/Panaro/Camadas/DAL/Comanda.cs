using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaro.Camadas.DAL
{
    public class Comanda
    {
        private string strcon = Conexao.getConexao();

        public List<Model.dgvconsulcomanda> Select()
        {
            List<Model.dgvconsulcomanda> lstdgv = new List<Model.dgvconsulcomanda>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select comandas.id, clientes.nome, status.descricao from comandas inner join status on (status.id=comandas.status) inner join clientes on (clientes.id=comandas.id_cliente) where status=1;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.dgvconsulcomanda dgvconsulcomanda = new Model.dgvconsulcomanda();
                    dgvconsulcomanda.id = Convert.ToInt32(reader["id"]);
                    dgvconsulcomanda.status = "Aberta";
                    dgvconsulcomanda.nome = reader["nome"].ToString();
                    lstdgv.Add(dgvconsulcomanda);


                    

                }
            }
            catch
            {
                Console.WriteLine("Erro - Comandas nao localizados");
            }
            finally
            {
                conexao.Close();
            }

            return lstdgv;
        }

        

        public void Insert(Model.Comanda comanda)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            try
            {
                string sql = "Insert into comandas values ";
                sql = sql + " (@id_cliente, @status);";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id_cliente", comanda.id_cliente);
                cmd.Parameters.AddWithValue("@status", comanda.status);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Deu Erro ao cadastrar a comanda " + ex);
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Update(Model.Comanda comanda)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Update comandas set status=@status where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@status", comanda.status);
            cmd.Parameters.AddWithValue("@id", comanda.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualizacao de comanda");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
