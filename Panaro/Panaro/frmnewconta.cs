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
    public partial class frmnewconta : Form
    {
        public frmnewconta()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmnewconta_Load(object sender, EventArgs e)
        {
            rbnao.Checked = true;
            Camadas.DAL.Contaspagar dalCont = new Camadas.DAL.Contaspagar();
            dgvcontas.DataSource = "";
            dgvcontas.DataSource = dalCont.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cadastrar o conta a pagar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                txtboxdesc.Focus();
                Camadas.Model.Contaspagar contaspagar = new Camadas.Model.Contaspagar();
                Camadas.DAL.Contaspagar dalCont = new Camadas.DAL.Contaspagar();
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



                dalCont.Insert(contaspagar);



                MessageBox.Show("Conta cadastrada com sucesso", "Cadastro de contas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxdesc.Focus();
                txtboxdesc.Text = ("");
                txtboxvalor.Text = ("");
                rbnao.Checked = true;
                datavenc.Value = DateTime.Now;
                dgvcontas.DataSource = "";
                dgvcontas.DataSource = dalCont.Select();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxdesc.Focus();
            txtboxdesc.Text = ("");
            txtboxvalor.Text = ("");
            rbnao.Checked = true;
            datavenc.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmedcontpag frmconta = new frmedcontpag();
            frmconta.Show();
            this.Close();
        }
    }
}
