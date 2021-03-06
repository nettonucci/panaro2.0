﻿using System;
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
    public partial class frmnewcli : Form
    {
        public frmnewcli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cadastrar o cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                txtboxnome.Focus();
                Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
                Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
                cliente.nome = txtboxnome.Text;
                cliente.endereco = txtboxend.Text;
                cliente.numero = txtboxnum.Text;
                cliente.bairro = txtboxbairro.Text;
                cliente.telefone = txtboxtel.Text;
                cliente.celular = txtboxcel.Text;
                cliente.datacad = DateTime.Now;

                dalCli.Insert(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxnome.Focus();
                txtboxnome.Text = ("");
                txtboxend.Text = ("");
                txtboxnum.Text = ("");
                txtboxbairro.Text = ("");
                txtboxtel.Text = ("");
                txtboxcel.Text = ("");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja limpar todos os campos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                txtboxnome.Focus();
                txtboxnome.Text = ("");
                txtboxend.Text = ("");
                txtboxnum.Text = ("");
                txtboxbairro.Text = ("");
                txtboxtel.Text = ("");
                txtboxcel.Text = ("");
                rdbsim.Checked = true;
                
            }
        }

        private void frmnewcli_Load(object sender, EventArgs e)
        {
            rdbsim.Checked = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmedcli frmedc = new frmedcli();
            frmedc.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtboxcel.Text == "" & txtboxtel.Text == "")
            {
                btncadastrar.Enabled = false;
            }
            else
            {
                btncadastrar.Enabled = true;
            } 
            if(rdbnao.Checked == true)
            {
                btncadastrar.Enabled = true;
            }

        }

        private void rdbsim_CheckedChanged(object sender, EventArgs e)
        {
            txtboxtel.Enabled = true;
            txtboxcel.Enabled = true;
        }

        private void rdbnao_CheckedChanged(object sender, EventArgs e)
        {
            txtboxtel.Enabled = false;
            txtboxcel.Enabled = false;
        }
    }
}
