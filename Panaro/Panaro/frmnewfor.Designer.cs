﻿namespace Panaro
{
    partial class frmnewfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnewfor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtboxnome = new System.Windows.Forms.TextBox();
            this.txtboxmarca = new System.Windows.Forms.TextBox();
            this.txtboxendereco = new System.Windows.Forms.TextBox();
            this.txtboxcelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxnumero = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet = new Panaro.panaroDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.tiposTableAdapter = new Panaro.panaroDataSetTableAdapters.tiposTableAdapter();
            this.panaroDataSet1 = new Panaro.panaroDataSet1();
            this.tiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiposTableAdapter1 = new Panaro.panaroDataSet1TableAdapters.tiposTableAdapter();
            this.panaroDataSet2 = new Panaro.panaroDataSet2();
            this.tiposTableAdapter2 = new Panaro.panaroDataSet2TableAdapters.tiposTableAdapter();
            this.cbboxtipos = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet6 = new Panaro.panaroDataSet6();
            this.tipoTableAdapter = new Panaro.panaroDataSet6TableAdapters.tipoTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panaroDataSet15 = new Panaro.panaroDataSet15();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new Panaro.panaroDataSet15TableAdapters.fornecedorTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(69, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 6;
            // 
            // txtboxnome
            // 
            this.txtboxnome.Location = new System.Drawing.Point(69, 48);
            this.txtboxnome.Name = "txtboxnome";
            this.txtboxnome.Size = new System.Drawing.Size(484, 20);
            this.txtboxnome.TabIndex = 1;
            // 
            // txtboxmarca
            // 
            this.txtboxmarca.Location = new System.Drawing.Point(69, 74);
            this.txtboxmarca.Name = "txtboxmarca";
            this.txtboxmarca.Size = new System.Drawing.Size(359, 20);
            this.txtboxmarca.TabIndex = 2;
            // 
            // txtboxendereco
            // 
            this.txtboxendereco.Location = new System.Drawing.Point(69, 100);
            this.txtboxendereco.Name = "txtboxendereco";
            this.txtboxendereco.Size = new System.Drawing.Size(359, 20);
            this.txtboxendereco.TabIndex = 3;
            // 
            // txtboxcelular
            // 
            this.txtboxcelular.Location = new System.Drawing.Point(69, 153);
            this.txtboxcelular.Name = "txtboxcelular";
            this.txtboxcelular.Size = new System.Drawing.Size(211, 20);
            this.txtboxcelular.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "N°:";
            // 
            // txtboxnumero
            // 
            this.txtboxnumero.Location = new System.Drawing.Point(462, 100);
            this.txtboxnumero.Name = "txtboxnumero";
            this.txtboxnumero.Size = new System.Drawing.Size(70, 20);
            this.txtboxnumero.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 158);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(142, 191);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 10;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Novo Tipo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "tipos";
            this.tiposBindingSource.DataSource = this.panaroDataSet;
            // 
            // panaroDataSet
            // 
            this.panaroDataSet.DataSetName = "panaroDataSet";
            this.panaroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tipo:";
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // panaroDataSet1
            // 
            this.panaroDataSet1.DataSetName = "panaroDataSet1";
            this.panaroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposBindingSource1
            // 
            this.tiposBindingSource1.DataMember = "tipos";
            this.tiposBindingSource1.DataSource = this.panaroDataSet1;
            // 
            // tiposTableAdapter1
            // 
            this.tiposTableAdapter1.ClearBeforeFill = true;
            // 
            // panaroDataSet2
            // 
            this.panaroDataSet2.DataSetName = "panaroDataSet2";
            this.panaroDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposTableAdapter2
            // 
            this.tiposTableAdapter2.ClearBeforeFill = true;
            // 
            // cbboxtipos
            // 
            this.cbboxtipos.DataSource = this.tipoBindingSource;
            this.cbboxtipos.DisplayMember = "descricao";
            this.cbboxtipos.FormattingEnabled = true;
            this.cbboxtipos.Location = new System.Drawing.Point(69, 126);
            this.cbboxtipos.Name = "cbboxtipos";
            this.cbboxtipos.Size = new System.Drawing.Size(121, 21);
            this.cbboxtipos.TabIndex = 22;
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.panaroDataSet6;
            // 
            // panaroDataSet6
            // 
            this.panaroDataSet6.DataSetName = "panaroDataSet6";
            this.panaroDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornecedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // panaroDataSet15
            // 
            this.panaroDataSet15.DataSetName = "panaroDataSet15";
            this.panaroDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.panaroDataSet15;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // frmnewfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 385);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbboxtipos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboxnumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxcelular);
            this.Controls.Add(this.txtboxendereco);
            this.Controls.Add(this.txtboxmarca);
            this.Controls.Add(this.txtboxnome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmnewfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de fornecedor";
            this.Load += new System.EventHandler(this.frmnewfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtboxnome;
        private System.Windows.Forms.TextBox txtboxmarca;
        private System.Windows.Forms.TextBox txtboxendereco;
        private System.Windows.Forms.TextBox txtboxcelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxnumero;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private panaroDataSet panaroDataSet;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private panaroDataSetTableAdapters.tiposTableAdapter tiposTableAdapter;
        private panaroDataSet1 panaroDataSet1;
        private System.Windows.Forms.BindingSource tiposBindingSource1;
        private panaroDataSet1TableAdapters.tiposTableAdapter tiposTableAdapter1;
        private panaroDataSet2 panaroDataSet2;
        private panaroDataSet2TableAdapters.tiposTableAdapter tiposTableAdapter2;
        private System.Windows.Forms.ComboBox cbboxtipos;
        private panaroDataSet6 panaroDataSet6;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private panaroDataSet6TableAdapters.tipoTableAdapter tipoTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private panaroDataSet15 panaroDataSet15;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private panaroDataSet15TableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
    }
}