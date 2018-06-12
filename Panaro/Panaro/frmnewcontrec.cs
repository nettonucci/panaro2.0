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
    public partial class frmnewcontrec : Form
    {
        public frmnewcontrec()
        {
            InitializeComponent();
        }

        private void frmnewcontrec_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet16.contasreceber'. Você pode movê-la ou removê-la conforme necessário.
            this.contasreceberTableAdapter.Fill(this.panaroDataSet16.contasreceber);
            Camadas.DAL.Contasreceber dalCont = new Camadas.DAL.Contasreceber();
            dgvcontas.DataSource = "";
            dgvcontas.DataSource = dalCont.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmedcontrec frmrec = new frmedcontrec();
            frmrec.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cadastrar uma nova conta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                Camadas.Model.Contasreceber contas = new Camadas.Model.Contasreceber();
                Camadas.DAL.Contasreceber dalCon = new Camadas.DAL.Contasreceber();
                txtboxdesc.Focus();
                contas.descricao = txtboxdesc.Text;
                contas.dataabert = dataabert.Text;
                contas.datavenc = datavenc.Text;
                contas.valor = txtboxvalor.Text;
                contas.pago = "Nao";

                dalCon.Insert(contas);
                MessageBox.Show("Conta cadastrada com sucesso", "Cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxdesc.Focus();
                txtboxdesc.Text = (" ");
                dataabert.Value = DateTime.Now;
                datavenc.Value = DateTime.Now;
                txtboxvalor.Text = (" ");
                dgvcontas.DataSource = "";
                dgvcontas.DataSource = dalCon.Select();
            }
        }
    }
}
