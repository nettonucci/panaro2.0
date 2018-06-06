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
            txtboxtotal.Text = "R$";
            Camadas.DAL.Produtos dalPro = new Camadas.DAL.Produtos();
            dgvcom.DataSource = "";
            dgvcom.DataSource = dalPro.Select();



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

            foreach (DataGridViewRow row in dgvcom.Rows)
            {
                total += Convert.ToDecimal(row.Cells["valor"].Value);
            }

            txtboxtotal.Text += Convert.ToString(total);
        }

        private void dgvcom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
