namespace Panaro
{
    partial class frmedcontpag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rbsim = new System.Windows.Forms.RadioButton();
            this.rbnao = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.datavenc = new System.Windows.Forms.DateTimePicker();
            this.txtboxvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxdesc = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.dgvcontas = new System.Windows.Forms.DataGridView();
            this.pnlpesquisa = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbnome = new System.Windows.Forms.RadioButton();
            this.rdbcod = new System.Windows.Forms.RadioButton();
            this.rdbtodos = new System.Windows.Forms.RadioButton();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontas)).BeginInit();
            this.pnlpesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbsim
            // 
            this.rbsim.AutoSize = true;
            this.rbsim.Location = new System.Drawing.Point(172, 127);
            this.rbsim.Name = "rbsim";
            this.rbsim.Size = new System.Drawing.Size(42, 17);
            this.rbsim.TabIndex = 27;
            this.rbsim.TabStop = true;
            this.rbsim.Text = "Sim";
            this.rbsim.UseVisualStyleBackColor = true;
            // 
            // rbnao
            // 
            this.rbnao.AutoSize = true;
            this.rbnao.Location = new System.Drawing.Point(121, 127);
            this.rbnao.Name = "rbnao";
            this.rbnao.Size = new System.Drawing.Size(45, 17);
            this.rbnao.TabIndex = 26;
            this.rbnao.TabStop = true;
            this.rbnao.Text = "Nao";
            this.rbnao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Pago:";
            // 
            // datavenc
            // 
            this.datavenc.CustomFormat = "dd-MM-yyyy";
            this.datavenc.Enabled = false;
            this.datavenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datavenc.Location = new System.Drawing.Point(121, 65);
            this.datavenc.Name = "datavenc";
            this.datavenc.Size = new System.Drawing.Size(93, 20);
            this.datavenc.TabIndex = 24;
            // 
            // txtboxvalor
            // 
            this.txtboxvalor.Enabled = false;
            this.txtboxvalor.Location = new System.Drawing.Point(121, 97);
            this.txtboxvalor.Name = "txtboxvalor";
            this.txtboxvalor.Size = new System.Drawing.Size(108, 20);
            this.txtboxvalor.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data de vencimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descriçao:";
            // 
            // txtboxdesc
            // 
            this.txtboxdesc.Enabled = false;
            this.txtboxdesc.Location = new System.Drawing.Point(121, 28);
            this.txtboxdesc.Name = "txtboxdesc";
            this.txtboxdesc.Size = new System.Drawing.Size(335, 20);
            this.txtboxdesc.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(93, 162);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 36;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(12, 162);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 35;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvcontas
            // 
            this.dgvcontas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontas.Location = new System.Drawing.Point(12, 229);
            this.dgvcontas.Name = "dgvcontas";
            this.dgvcontas.Size = new System.Drawing.Size(776, 209);
            this.dgvcontas.TabIndex = 38;
            this.dgvcontas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcontas_CellContentClick);
            this.dgvcontas.DoubleClick += new System.EventHandler(this.dgvcontas_DoubleClick);
            // 
            // pnlpesquisa
            // 
            this.pnlpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpesquisa.Controls.Add(this.btnbuscar);
            this.pnlpesquisa.Controls.Add(this.txtPesquisa);
            this.pnlpesquisa.Controls.Add(this.lblPesquisa);
            this.pnlpesquisa.Controls.Add(this.groupBox1);
            this.pnlpesquisa.Location = new System.Drawing.Point(506, 28);
            this.pnlpesquisa.Name = "pnlpesquisa";
            this.pnlpesquisa.Size = new System.Drawing.Size(216, 181);
            this.pnlpesquisa.TabIndex = 39;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(128, 150);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(14, 124);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(189, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(11, 108);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(192, 23);
            this.lblPesquisa.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbnome);
            this.groupBox1.Controls.Add(this.rdbcod);
            this.groupBox1.Controls.Add(this.rdbtodos);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // rdbnome
            // 
            this.rdbnome.AutoSize = true;
            this.rdbnome.Location = new System.Drawing.Point(16, 74);
            this.rdbnome.Name = "rdbnome";
            this.rdbnome.Size = new System.Drawing.Size(53, 17);
            this.rdbnome.TabIndex = 2;
            this.rdbnome.Text = "Nome";
            this.rdbnome.UseVisualStyleBackColor = true;
            this.rdbnome.CheckedChanged += new System.EventHandler(this.rdbnome_CheckedChanged);
            // 
            // rdbcod
            // 
            this.rdbcod.AutoSize = true;
            this.rdbcod.Location = new System.Drawing.Point(16, 51);
            this.rdbcod.Name = "rdbcod";
            this.rdbcod.Size = new System.Drawing.Size(58, 17);
            this.rdbcod.TabIndex = 1;
            this.rdbcod.Text = "Codigo";
            this.rdbcod.UseVisualStyleBackColor = true;
            this.rdbcod.CheckedChanged += new System.EventHandler(this.rdbcod_CheckedChanged);
            // 
            // rdbtodos
            // 
            this.rdbtodos.AutoSize = true;
            this.rdbtodos.Checked = true;
            this.rdbtodos.Location = new System.Drawing.Point(16, 28);
            this.rdbtodos.Name = "rdbtodos";
            this.rdbtodos.Size = new System.Drawing.Size(55, 17);
            this.rdbtodos.TabIndex = 0;
            this.rdbtodos.TabStop = true;
            this.rdbtodos.Text = "Todos";
            this.rdbtodos.UseVisualStyleBackColor = true;
            this.rdbtodos.CheckedChanged += new System.EventHandler(this.rdbtodos_CheckedChanged);
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(239, 65);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(60, 20);
            this.txtboxid.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Selecione uma conta abaixo para ediçao ou exclusao";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmedcontpag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.pnlpesquisa);
            this.Controls.Add(this.dgvcontas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.rbsim);
            this.Controls.Add(this.rbnao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datavenc);
            this.Controls.Add(this.txtboxvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxdesc);
            this.Name = "frmedcontpag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar contas a pagar";
            this.Load += new System.EventHandler(this.frmedcontpag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontas)).EndInit();
            this.pnlpesquisa.ResumeLayout(false);
            this.pnlpesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbsim;
        private System.Windows.Forms.RadioButton rbnao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datavenc;
        private System.Windows.Forms.TextBox txtboxvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxdesc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.DataGridView dgvcontas;
        private System.Windows.Forms.Panel pnlpesquisa;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbnome;
        private System.Windows.Forms.RadioButton rdbcod;
        private System.Windows.Forms.RadioButton rdbtodos;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}