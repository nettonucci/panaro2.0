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
    public partial class frmcaixa : Form
    {
        public frmcaixa()
        {
            InitializeComponent();
        }

        private void frmcaixa_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Caixa dalCai = new Camadas.DAL.Caixa();
            dgvcaixa.DataSource = "";
            dgvcaixa.DataSource = dalCai.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
