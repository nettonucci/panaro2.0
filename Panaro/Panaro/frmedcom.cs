using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaro
{
    public partial class frmedcom : Form
    {
        public frmedcom()
        {
            InitializeComponent();
        }

        public frmedcom(string id_cliente, string id)
        {
            InitializeComponent();
            txtboxnome.Text = id_cliente;
            txtboxid.Text = id.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmconsulta_Load(object sender, EventArgs e)
        {
            decimal total = 0;
            txtboxtotal.Text = "R$";

            foreach (DataGridViewRow row in dgvcom.Rows)
            {
                total += Convert.ToDecimal(row.Cells["valor"].Value);
            }

            txtboxtotal.Text += Convert.ToString(total);

            rdbnao.Checked = true;
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet11.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter2.Fill(this.panaroDataSet11.produtos);
            Camadas.BLL.Venda bllVen = new Camadas.BLL.Venda();
            List<Camadas.Model.Venda> lstVenda = new List<Camadas.Model.Venda>();

            
                lstVenda = bllVen.SelectById(Convert.ToInt32(txtboxid.Text));


            dgvcom.DataSource = "";
            dgvcom.DataSource = lstVenda;
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet10.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter1.Fill(this.panaroDataSet10.produtos);
            txtboxtotal.Text = "R$";
            Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();
            //dgvcom.DataSource = "";
            //dgvcom.DataSource = dalPro.Select();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja finalizar a comanda?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                txtboxtotal.Text = "R$";
                decimal total = 0;

                foreach (DataGridViewRow row in dgvcom.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["valor"].Value);
                }

                txtboxtotal.Text += Convert.ToString(total);

                Camadas.Model.Comanda comanda = new Camadas.Model.Comanda();
                Camadas.DAL.Comanda dalCom = new Camadas.DAL.Comanda();

                comanda.id = Convert.ToInt32(txtboxid.Text);
                comanda.status = "2";

                dalCom.Update(comanda);

                Camadas.Model.Caixa caixa = new Camadas.Model.Caixa();
                Camadas.DAL.Caixa dalCai = new Camadas.DAL.Caixa();
                caixa.cliente = txtboxnome.Text;
                caixa.data = DateTime.Now;
                caixa.total = txtboxtotal.Text;

                dalCai.Insert(caixa);


                MessageBox.Show("Comanda encerrada com sucesso", "Finalizar comanda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvComanda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            txtboxtotal.Text = "R$";

            foreach (DataGridViewRow row in dgvcom.Rows)
            {
                total += Convert.ToDecimal(row.Cells["valor"].Value);
            }

            txtboxtotal.Text += Convert.ToString(total);
        }

        private void dgvcom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvprod_DoubleClick(object sender, EventArgs e)
        {
            txtboxprodid.Text = dgvprod.SelectedRows[0].Cells["id"].Value.ToString();
            txtboxproddesc.Text = dgvprod.SelectedRows[0].Cells["descricao"].Value.ToString();
            txtboxprodvalor.Text = dgvprod.SelectedRows[0].Cells["valor"].Value.ToString();
            txtboxprodqtd.Text = dgvprod.SelectedRows[0].Cells["quantidade"].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Camadas.Model.Venda venda = new Camadas.Model.Venda();
            Camadas.DAL.Venda dalVen = new Camadas.DAL.Venda();

            venda.id = Convert.ToInt32(txtboxcomid.Text);

            dalVen.Delete(venda);

            txtboxcomid.Text = ("");
            txtnada.Text = ("");
            txtboxcomvalor.Text = ("");
            Camadas.BLL.Venda bllVen = new Camadas.BLL.Venda();
            List<Camadas.Model.Venda> lstVenda = new List<Camadas.Model.Venda>();


            lstVenda = bllVen.SelectById(Convert.ToInt32(txtboxid.Text));


            dgvcom.DataSource = "";
            dgvcom.DataSource = lstVenda;

            decimal total = 0;
            txtboxtotal.Text = "R$";

            foreach (DataGridViewRow row in dgvcom.Rows)
            {
                total += Convert.ToDecimal(row.Cells["valor"].Value);
            }

            txtboxtotal.Text += Convert.ToString(total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Camadas.Model.Venda venda = new Camadas.Model.Venda();
            Camadas.DAL.Venda dalVen = new Camadas.DAL.Venda();
            venda.id_produto = Convert.ToInt32(txtboxprodid.Text);
            venda.id_comanda = Convert.ToInt32(txtboxid.Text);
            venda.valor = txtboxprodvalor.Text;

            dalVen.Insert(venda);

            Camadas.Model.Produtos produto = new Camadas.Model.Produtos();
            Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();

            int soma = Convert.ToInt32(txtboxprodqtd.Text);
            soma --;
            txtboxprodqtd.Text = Convert.ToString(soma);
            produto.id  = Convert.ToInt32(txtboxprodid.Text);
            produto.quantidade = Convert.ToInt32(txtboxprodqtd.Text);
            produto.valor = txtboxprodvalor.Text;
            dalPro.Update(produto);

            dgvprod.DataSource = "";

            txtboxprodid.Text = ("");
            txtboxproddesc.Text = ("");
            txtboxprodvalor.Text = ("");
            txtboxprodqtd.Text = ("");
            rdbnao.Checked = true;
            dgvcom.DataSource = "";
            Camadas.BLL.Venda bllVen = new Camadas.BLL.Venda();
            List<Camadas.Model.Venda> lstVenda = new List<Camadas.Model.Venda>();


            lstVenda = bllVen.SelectById(Convert.ToInt32(txtboxid.Text));


            dgvcom.DataSource = "";
            dgvcom.DataSource = lstVenda;

            decimal total = 0;
            txtboxtotal.Text = "R$";

            foreach (DataGridViewRow row in dgvcom.Rows)
            {
                total += Convert.ToDecimal(row.Cells["valor"].Value);
            }

            txtboxtotal.Text += Convert.ToString(total);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtboxprodvalor.Text == "")
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }

            if (txtboxcomid.Text == "")
            {
                btnrem.Enabled = false;
            }
            else
            {
                btnrem.Enabled = true;
            }
        }

        private void dgvcom_DoubleClick(object sender, EventArgs e)
        {
            txtboxcomid.Text = dgvcom.SelectedRows[0].Cells["id"].Value.ToString();
            txtboxcomdesc.Text = dgvcom.SelectedRows[0].Cells["id_produto"].Value.ToString();
            txtboxcomvalor.Text = dgvcom.SelectedRows[0].Cells["valor"].Value.ToString();
            txtnada.Text = dgvcom.SelectedRows[0].Cells["descricao"].Value.ToString();
        }

        private void rdbnao_CheckedChanged(object sender, EventArgs e)
        {
            dgvprod.Enabled = true;
            txtboxproddesc.Text = "";
            txtboxprodid.Text = "";
            txtboxprodid.Enabled = false;
            txtboxproddesc.Enabled = false;
            txtboxprodvalor.Enabled = false;
        }

        private void rdbsim_CheckedChanged(object sender, EventArgs e)
        {
            dgvprod.Enabled = false;
            txtboxprodvalor.Text = "";
            txtboxprodid.Text = "0";
            txtboxproddesc.Text = "0";
            txtboxprodvalor.Enabled = true;
        }

        private void dgvcom_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
