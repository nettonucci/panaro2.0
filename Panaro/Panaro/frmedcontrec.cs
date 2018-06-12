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
    public partial class frmedcontrec : Form
    {
        public frmedcontrec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmedcontrec_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet17.contasreceber'. Você pode movê-la ou removê-la conforme necessário.
            this.contasreceberTableAdapter.Fill(this.panaroDataSet17.contasreceber);
            Camadas.DAL.Contasreceber dalCont = new Camadas.DAL.Contasreceber();
            dgvcontas.DataSource = "";
            dgvcontas.DataSource = dalCont.Select();
            rdbnao.Checked = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover a Conta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                Camadas.Model.Contasreceber contas = new Camadas.Model.Contasreceber();
                Camadas.DAL.Contasreceber dalCon = new Camadas.DAL.Contasreceber();

                contas.id = Convert.ToInt32(txtboxid.Text);

                dalCon.Delete(contas);

                MessageBox.Show("Conta removida com sucesso", "Alterar contas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxdesc.Focus();
                txtboxdesc.Text = ("");
                txtboxvalor.Text = ("");
                txtboxid.Text = ("");
                rdbnao.Checked = true;
                datavenc.Value = DateTime.Now;
                dgvcontas.DataSource = "";
                dgvcontas.DataSource = dalCon.Select();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar a conta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Camadas.Model.Contasreceber contas = new Camadas.Model.Contasreceber();
                Camadas.DAL.Contasreceber dalCon = new Camadas.DAL.Contasreceber();

                contas.id = Convert.ToInt32(txtboxid.Text);
                contas.valor = txtboxvalor.Text;
                if (rdbnao.Checked == true)
                {
                    contas.pago = "Nao";
                }
                else if (rdbsim.Checked == true)
                {
                    contas.pago = "Sim";
                }

                dalCon.Update(contas);


                MessageBox.Show("Conta alterada com sucesso", "Alterar contas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxdesc.Focus();
                txtboxid.Text = ("");
                txtboxdesc.Text = ("");
                txtboxvalor.Text = ("");
                rdbnao.Checked = true;
                datavenc.Value = DateTime.Now;
                dgvcontas.DataSource = "";
                dgvcontas.DataSource = dalCon.Select();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void rbnao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvcontas_DoubleClick(object sender, EventArgs e)
        {
            txtboxid.Text = dgvcontas.SelectedRows[0].Cells["id"].Value.ToString();
            txtboxdesc.Text = dgvcontas.SelectedRows[0].Cells["descricao"].Value.ToString();
            datavenc.Text = dgvcontas.SelectedRows[0].Cells["datavenc2"].Value.ToString();
            txtboxvalor.Text = dgvcontas.SelectedRows[0].Cells["valor"].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txtboxid.Text == "")
            {
                btnalterar.Enabled = false;
                btnexcluir.Enabled = false;
            }
            else
            {
                btnexcluir.Enabled = true;
                btnalterar.Enabled = true;
            }
        }
    }
}
