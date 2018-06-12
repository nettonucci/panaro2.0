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
    public partial class frmconcom : Form
    {
        public frmconcom()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {

            Camadas.DAL.Comanda dalCom = new Camadas.DAL.Comanda();
            dgvComanda.DataSource = "";
            dgvComanda.DataSource = dalCom.Select();
            txtboxid.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvComanda_DoubleClick(object sender, EventArgs e)
        {
            if (dgvComanda.SelectedRows.Count > 0)
            {
                txtboxCom.Text = dgvComanda.SelectedRows[0].Cells["nome"].Value.ToString();
                txtboxid.Text = dgvComanda.SelectedRows[0].Cells["id"].Value.ToString();
            }
        }

        private void txtboxCom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.Model.Comanda comanda = new Camadas.Model.Comanda();
            Camadas.DAL.Comanda dalCom = new Camadas.DAL.Comanda();

            comanda.id = Convert.ToInt32(txtboxid.Text);
            comanda.status = "2";
            dalCom.Update(comanda);
            frmedcom frmcom = new frmedcom(txtboxCom.Text, txtboxid.Text);

            frmcom.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtboxCom.Text == "")
            {
                btneditar.Enabled = false;
            }
            else
            {
                btneditar.Enabled = true;
            }
        }
    }
}
