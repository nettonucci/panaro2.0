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
            // TODO: esta linha de código carrega dados na tabela 'panaroDataSet18.caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.caixaTableAdapter.Fill(this.panaroDataSet18.caixa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
