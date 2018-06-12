using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Caixa
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Caixa> Select()
        {
            List<Model.Caixa> lstCaixa = new List<Model.Caixa>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from caixa;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Caixa caixa = new Model.Caixa();
                    caixa.id = Convert.ToInt32(reader["id"]);
                    caixa.cliente = reader["cliente"].ToString();
                    caixa.data = Convert.ToDateTime(reader["data"]);
                    caixa.total = reader["total"].ToString();
                    caixa.pagamento = reader["pagamento"].ToString();
                    lstCaixa.Add(caixa);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Caixas nao localizados");
            }
            finally
            {
                conexao.Close();
            }

            return lstCaixa;
        }

        public void Insert(Model.Caixa caixa)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into caixa values ";
            sql = sql + " (@cliente, @data, @total, @pagamento);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", caixa.cliente);
            cmd.Parameters.AddWithValue("@data", caixa.data);
            cmd.Parameters.AddWithValue("@total", caixa.total);
            cmd.Parameters.AddWithValue("@pagamento", caixa.pagamento);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar o caixa");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
