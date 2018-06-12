namespace Panaro
{
    partial class frmedcontrec
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
            this.rdbsim = new System.Windows.Forms.RadioButton();
            this.rdbnao = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.datavenc = new System.Windows.Forms.DateTimePicker();
            this.txtboxvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxdesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbnome = new System.Windows.Forms.RadioButton();
            this.rdbcod = new System.Windows.Forms.RadioButton();
            this.rdbtodos = new System.Windows.Forms.RadioButton();
            this.pnlpesquisa = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.dgvcontas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataabert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavenc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contasreceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet17 = new Panaro.panaroDataSet17();
            this.contasreceberTableAdapter = new Panaro.panaroDataSet17TableAdapters.contasreceberTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.pnlpesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbsim
            // 
            this.rdbsim.AutoSize = true;
            this.rdbsim.Location = new System.Drawing.Point(207, 139);
            this.rdbsim.Name = "rdbsim";
            this.rdbsim.Size = new System.Drawing.Size(42, 17);
            this.rdbsim.TabIndex = 36;
            this.rdbsim.TabStop = true;
            this.rdbsim.Text = "Sim";
            this.rdbsim.UseVisualStyleBackColor = true;
            // 
            // rdbnao
            // 
            this.rdbnao.AutoSize = true;
            this.rdbnao.Location = new System.Drawing.Point(156, 139);
            this.rdbnao.Name = "rdbnao";
            this.rdbnao.Size = new System.Drawing.Size(45, 17);
            this.rdbnao.TabIndex = 35;
            this.rdbnao.TabStop = true;
            this.rdbnao.Text = "Nao";
            this.rdbnao.UseVisualStyleBackColor = true;
            this.rdbnao.CheckedChanged += new System.EventHandler(this.rbnao_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Pago:";
            // 
            // datavenc
            // 
            this.datavenc.CustomFormat = "dd-MM-yyyy";
            this.datavenc.Enabled = false;
            this.datavenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datavenc.Location = new System.Drawing.Point(156, 71);
            this.datavenc.Name = "datavenc";
            this.datavenc.Size = new System.Drawing.Size(88, 20);
            this.datavenc.TabIndex = 33;
            // 
            // txtboxvalor
            // 
            this.txtboxvalor.Location = new System.Drawing.Point(156, 104);
            this.txtboxvalor.Name = "txtboxvalor";
            this.txtboxvalor.Size = new System.Drawing.Size(108, 20);
            this.txtboxvalor.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data de vencimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Descriçao:";
            // 
            // txtboxdesc
            // 
            this.txtboxdesc.Enabled = false;
            this.txtboxdesc.Location = new System.Drawing.Point(156, 34);
            this.txtboxdesc.Name = "txtboxdesc";
            this.txtboxdesc.Size = new System.Drawing.Size(318, 20);
            this.txtboxdesc.TabIndex = 28;
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
            // 
            // pnlpesquisa
            // 
            this.pnlpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpesquisa.Controls.Add(this.btnbuscar);
            this.pnlpesquisa.Controls.Add(this.txtPesquisa);
            this.pnlpesquisa.Controls.Add(this.lblPesquisa);
            this.pnlpesquisa.Controls.Add(this.groupBox1);
            this.pnlpesquisa.Location = new System.Drawing.Point(483, 28);
            this.pnlpesquisa.Name = "pnlpesquisa";
            this.pnlpesquisa.Size = new System.Drawing.Size(216, 181);
            this.pnlpesquisa.TabIndex = 40;
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
            this.lblPesquisa.Location = new System.Drawing.Point(11, 121);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(192, 23);
            this.lblPesquisa.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(126, 179);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 45;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(45, 179);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 44;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvcontas
            // 
            this.dgvcontas.AutoGenerateColumns = false;
            this.dgvcontas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.dataabert,
            this.datavenc2,
            this.valor,
            this.pago});
            this.dgvcontas.DataSource = this.contasreceberBindingSource;
            this.dgvcontas.Location = new System.Drawing.Point(44, 224);
            this.dgvcontas.Name = "dgvcontas";
            this.dgvcontas.Size = new System.Drawing.Size(643, 209);
            this.dgvcontas.TabIndex = 47;
            this.dgvcontas.DoubleClick += new System.EventHandler(this.dgvcontas_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "descricao";
            this.descricao.Name = "descricao";
            // 
            // dataabert
            // 
            this.dataabert.DataPropertyName = "dataabert";
            this.dataabert.HeaderText = "dataabert";
            this.dataabert.Name = "dataabert";
            // 
            // datavenc2
            // 
            this.datavenc2.DataPropertyName = "datavenc";
            this.datavenc2.HeaderText = "datavenc";
            this.datavenc2.Name = "datavenc2";
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "valor";
            this.valor.Name = "valor";
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "pago";
            this.pago.Name = "pago";
            // 
            // contasreceberBindingSource
            // 
            this.contasreceberBindingSource.DataMember = "contasreceber";
            this.contasreceberBindingSource.DataSource = this.panaroDataSet17;
            // 
            // panaroDataSet17
            // 
            this.panaroDataSet17.DataSetName = "panaroDataSet17";
            this.panaroDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasreceberTableAdapter
            // 
            this.contasreceberTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Selecione uma conta abaixo para ediçao ou exclusao";
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(156, 8);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(45, 20);
            this.txtboxid.TabIndex = 49;
            this.txtboxid.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmedcontrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 444);
            this.ControlBox = false;
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvcontas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.pnlpesquisa);
            this.Controls.Add(this.rdbsim);
            this.Controls.Add(this.rdbnao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datavenc);
            this.Controls.Add(this.txtboxvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxdesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmedcontrec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Contas a Receber";
            this.Load += new System.EventHandler(this.frmedcontrec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlpesquisa.ResumeLayout(false);
            this.pnlpesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbsim;
        private System.Windows.Forms.RadioButton rdbnao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datavenc;
        private System.Windows.Forms.TextBox txtboxvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxdesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbnome;
        private System.Windows.Forms.RadioButton rdbcod;
        private System.Windows.Forms.RadioButton rdbtodos;
        private System.Windows.Forms.Panel pnlpesquisa;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.DataGridView dgvcontas;
        private panaroDataSet17 panaroDataSet17;
        private System.Windows.Forms.BindingSource contasreceberBindingSource;
        private panaroDataSet17TableAdapters.contasreceberTableAdapter contasreceberTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataabert;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavenc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.Timer timer1;
    }
}