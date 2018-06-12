namespace Panaro
{
    partial class frmnewcontrec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnewcontrec));
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxdesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxvalor = new System.Windows.Forms.TextBox();
            this.datavenc = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataabert = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvcontas = new System.Windows.Forms.DataGridView();
            this.panaroDataSet16 = new Panaro.panaroDataSet16();
            this.contasreceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasreceberTableAdapter = new Panaro.panaroDataSet16TableAdapters.contasreceberTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataabertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descricao:";
            // 
            // txtboxdesc
            // 
            this.txtboxdesc.Location = new System.Drawing.Point(168, 33);
            this.txtboxdesc.Name = "txtboxdesc";
            this.txtboxdesc.Size = new System.Drawing.Size(409, 20);
            this.txtboxdesc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Abertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Vencimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor:";
            // 
            // txtboxvalor
            // 
            this.txtboxvalor.Location = new System.Drawing.Point(168, 205);
            this.txtboxvalor.Name = "txtboxvalor";
            this.txtboxvalor.Size = new System.Drawing.Size(136, 20);
            this.txtboxvalor.TabIndex = 5;
            // 
            // datavenc
            // 
            this.datavenc.CustomFormat = "dd-MM-yyyy";
            this.datavenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datavenc.Location = new System.Drawing.Point(168, 149);
            this.datavenc.Name = "datavenc";
            this.datavenc.Size = new System.Drawing.Size(91, 20);
            this.datavenc.TabIndex = 6;
            // 
            // dataabert
            // 
            this.dataabert.CustomFormat = "dd-MM-yyyy";
            this.dataabert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataabert.Location = new System.Drawing.Point(168, 88);
            this.dataabert.Name = "dataabert";
            this.dataabert.Size = new System.Drawing.Size(91, 20);
            this.dataabert.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 161);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvcontas
            // 
            this.dgvcontas.AutoGenerateColumns = false;
            this.dgvcontas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataabertDataGridViewTextBoxColumn,
            this.datavencDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn});
            this.dgvcontas.DataSource = this.contasreceberBindingSource;
            this.dgvcontas.Location = new System.Drawing.Point(15, 317);
            this.dgvcontas.Name = "dgvcontas";
            this.dgvcontas.Size = new System.Drawing.Size(648, 176);
            this.dgvcontas.TabIndex = 13;
            // 
            // panaroDataSet16
            // 
            this.panaroDataSet16.DataSetName = "panaroDataSet16";
            this.panaroDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasreceberBindingSource
            // 
            this.contasreceberBindingSource.DataMember = "contasreceber";
            this.contasreceberBindingSource.DataSource = this.panaroDataSet16;
            // 
            // contasreceberTableAdapter
            // 
            this.contasreceberTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // dataabertDataGridViewTextBoxColumn
            // 
            this.dataabertDataGridViewTextBoxColumn.DataPropertyName = "dataabert";
            this.dataabertDataGridViewTextBoxColumn.HeaderText = "dataabert";
            this.dataabertDataGridViewTextBoxColumn.Name = "dataabertDataGridViewTextBoxColumn";
            // 
            // datavencDataGridViewTextBoxColumn
            // 
            this.datavencDataGridViewTextBoxColumn.DataPropertyName = "datavenc";
            this.datavencDataGridViewTextBoxColumn.HeaderText = "datavenc";
            this.datavencDataGridViewTextBoxColumn.Name = "datavencDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            // 
            // frmnewcontrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 505);
            this.ControlBox = false;
            this.Controls.Add(this.dgvcontas);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataabert);
            this.Controls.Add(this.datavenc);
            this.Controls.Add(this.txtboxvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxdesc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmnewcontrec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.frmnewcontrec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxvalor;
        private System.Windows.Forms.DateTimePicker datavenc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dataabert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvcontas;
        private panaroDataSet16 panaroDataSet16;
        private System.Windows.Forms.BindingSource contasreceberBindingSource;
        private panaroDataSet16TableAdapters.contasreceberTableAdapter contasreceberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataabertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
    }
}