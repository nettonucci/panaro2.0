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

        public List<Model.Comanda> Select()
        {
            List<Model.Comanda> lstComanda = new List<Model.Comanda>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from comandas where status=1;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Comanda comanda = new Model.Comanda();
                    comanda.id = Convert.ToInt32(reader["id"]);
                    comanda.status = "Aberta";
                    comanda.id_cliente = Convert.ToInt32(reader["id_cliente"]);
                    lstComanda.Add(comanda);

                    

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

            return lstComanda;
        }

        

        public void Insert(Model.Comanda comanda)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            try
            {
                string sql = "Insert into comandas values ";
                sql = sql + " (@status, @id_cliente);";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@status", comanda.status);
                cmd.Parameters.AddWithValue("@id_cliente", comanda.id_cliente);
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
