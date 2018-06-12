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
    public partial class frmfinalizar : Form
    {
        public frmfinalizar()
        {
            InitializeComponent();
        }

        public frmfinalizar(string id, string id_cliente, string valor)
        {
            InitializeComponent();
            txtboxnome.Text = id_cliente;
            txtboxid.Text = id.ToString();
            txtboxtotal.Text = valor.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja finalizar esta comanda?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Camadas.Model.Comanda comanda = new Camadas.Model.Comanda();
                Camadas.DAL.Comanda dalCom = new Camadas.DAL.Comanda();

                comanda.id = Convert.ToInt32(txtboxid.Text);
                comanda.status = "3";

                dalCom.Update(comanda);

                Camadas.Model.Caixa caixa = new Camadas.Model.Caixa();
                Camadas.DAL.Caixa dalCai = new Camadas.DAL.Caixa();
                caixa.cliente = txtboxnome.Text;
                caixa.data = DateTime.Now;
                caixa.total = txtboxtotal2.Text;
                caixa.pagamento = comboforma.Text;

                dalCai.Insert(caixa);


                MessageBox.Show("Comanda encerrada com sucesso", "Finalizar comanda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmedcom)
                    {
                        frm.Close();
                        break;
                    }
                }
            }
        }

        private void frmfinalizar_Load(object sender, EventArgs e)
        {
            rdbreais.Checked = true;
            txtboxdescp.Enabled = false;           
            txtboxdescr.Text = "0";
            txtboxdescp.Text = "0";
            float soma = float.Parse(txtboxtotal.Text);
            float desc = float.Parse(txtboxdescr.Text);
            float total = soma - desc;
            txtboxtotal2.Text = Convert.ToString("R$" + total);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rdbreais.Checked == true)
            {
                float soma = float.Parse(txtboxtotal.Text);
                float desc = float.Parse(txtboxdescr.Text);
                float total = soma - desc;
                txtboxtotal2.Text = Convert.ToString("R$" + total);
            }
            else
            {
                float soma = float.Parse(txtboxtotal.Text);
                float desc = float.Parse(txtboxdescp.Text);
                float total = soma - ((desc/100)*soma);
                txtboxtotal2.Text = Convert.ToString("R$" + total);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbreais_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbreais.Checked == true)
            {
                txtboxdescr.Enabled = true;
            }
            else
            {
                txtboxdescr.Enabled = false;
            }
            txtboxdescr.Text = "0";
            txtboxdescp.Text = "0";
            float soma = float.Parse(txtboxtotal.Text);
            float desc = float.Parse(txtboxdescr.Text);
            float total = soma - desc;
            txtboxtotal2.Text = Convert.ToString("R$" + total);
        }

        private void rdbporc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbporc.Checked == false)
            {
                txtboxdescp.Enabled = false;
            }
            else
            {
                txtboxdescp.Enabled = true;
            }
            txtboxdescr.Text = "0";
            txtboxdescp.Text = "0";
            float soma = float.Parse(txtboxtotal.Text);
            float desc = float.Parse(txtboxdescp.Text);
            float total = soma - ((desc / 100) * soma);
            txtboxtotal2.Text = Convert.ToString("R$" + total);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(comboforma.Text == "")
            {
                btnfinalizar.Enabled = false;
            }
            else
            {
                btnfinalizar.Enabled = true;
            }
        }
    }
}