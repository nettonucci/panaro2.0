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
    public partial class frmedcontpag : Form
    {
        public frmedcontpag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmedcontpag_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Contaspagar dalCont = new Camadas.DAL.Contaspagar();
            dgvcontas.DataSource = "";
            dgvcontas.DataSource = dalCont.Select();
            txtboxid.Visible = false;
            rbnao.Checked = true;
            rdbtodos_CheckedChanged(null, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar a conta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Camadas.Model.Contaspagar contaspagar = new Camadas.Model.Contaspagar();
                Camadas.DAL.Contaspagar dalCont = new Camadas.DAL.Contaspagar();

                contaspagar.id = Convert.ToInt32(txtboxid.Text);
                contaspagar.descricao = txtboxdesc.Text;
                contaspagar.data = datavenc.Text;
                contaspagar.valor = txtboxvalor.Text;
                if (rbnao.Checked == true)
                {
                    contaspagar.pago = "Nao";
                }
                else if (rbsim.Checked == true)
                {
                    contaspagar.pago = "Sim";
                }

                dalCont.Update(contaspagar);


                MessageBox.Show("Conta alterada com sucesso", "Alterar contas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxdesc.Focus();
                txtboxdesc.Text = ("");
                txtboxvalor.Text = ("");
                rbnao.Checked = true;
                datavenc.Value = DateTime.Now;
                dgvcontas.DataSource = "";
                dgvcontas.DataSource = dalCont.Select();
            }
        }

        private void dgvcontas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvcontas.SelectedRows.Count > 0)
            {
                txtboxid.Text = dgvcontas.SelectedRows[0].Cells["id"].Value.ToString();
                txtboxdesc.Text = dgvcontas.SelectedRows[0].Cells["descricao"].Value.ToString();
                datavenc.Text = dgvcontas.SelectedRows[0].Cells["data"].Value.ToString();
                txtboxvalor.Text = dgvcontas.SelectedRows[0].Cells["valor"].Value.ToString();
    
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover a Conta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                Camadas.Model.Contaspagar contaspagar = new Camadas.Model.Contaspagar();
                Camadas.DAL.Contaspagar dalCont = new Camadas.DAL.Contaspagar();

                contaspagar.id = Convert.ToInt32(txtboxid.Text);

                dalCont.Delete(contaspagar);

                MessageBox.Show("Conta removida com sucesso", "Alterar contas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxdesc.Focus();
                txtboxdesc.Text = ("");
                txtboxvalor.Text = ("");
                rbnao.Checked = true;
                datavenc.Value = DateTime.Now;
                dgvcontas.DataSource = "";
                dgvcontas.DataSource = dalCont.Select();
            }
        }

        private void rdbcod_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Contaspagar bllContaspagar = new Camadas.BLL.Contaspagar();
            dgvcontas.DataSource = "";
            dgvcontas.DataSource = bllContaspagar.Select();
            lblPesquisa.Text = "Informe o Codigo";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnbuscar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbnome_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Contaspagar bllContaspagar = new Camadas.BLL.Contaspagar();
            dgvcontas.DataSource = "";
            dgvcontas.DataSource = bllContaspagar.Select();
            lblPesquisa.Text = "Informe o Nome";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnbuscar.Visible = true;
            txtPesquisa.Focus();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Contaspagar bllCont = new Camadas.BLL.Contaspagar();
            List<Camadas.Model.Contaspagar> lstContaspagar = new List<Camadas.Model.Contaspagar>();

            if (rdbcod.Checked)
                lstContaspagar = bllCont.SelectById(Convert.ToInt32(txtPesquisa.Text));
            else if (rdbnome.Checked)
                lstContaspagar = bllCont.SelectByDesc(txtPesquisa.Text);

            dgvcontas.DataSource = "";
            dgvcontas.DataSource = lstContaspagar;
            txtPesquisa.Text = "";
        }

        private void rdbtodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnbuscar.Visible = false;
            Camadas.BLL.Contaspagar bllContaspagar = new Camadas.BLL.Contaspagar();
            dgvcontas.DataSource = "";
            dgvcontas.DataSource = bllContaspagar.Select();
        }

        private void dgvcontas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtboxid.Text == "")
            {
                btnalterar.Enabled = false;
            }
            else
            {
                btnalterar.Enabled = true;
            }

            if (txtboxid.Text == "")
            {
                btnexcluir.Enabled = false;
            }
            else
            {
                btnexcluir.Enabled = true;
            }
        }
    }
}
