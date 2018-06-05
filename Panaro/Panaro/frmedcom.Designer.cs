namespace Panaro
{
    partial class frmedcom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet5 = new Panaro.panaroDataSet5();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet4 = new Panaro.panaroDataSet4();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxnome = new System.Windows.Forms.TextBox();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.tiposTableAdapter = new Panaro.panaroDataSet4TableAdapters.tiposTableAdapter();
            this.tiposTableAdapter1 = new Panaro.panaroDataSet5TableAdapters.tiposTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.txtboxtotal = new System.Windows.Forms.TextBox();
            this.panaroDataSet9 = new Panaro.panaroDataSet9();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Panaro.panaroDataSet9TableAdapters.produtosTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvcom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // tiposBindingSource1
            // 
            this.tiposBindingSource1.DataMember = "tipos";
            this.tiposBindingSource1.DataSource = this.panaroDataSet5;
            // 
            // panaroDataSet5
            // 
            this.panaroDataSet5.DataSetName = "panaroDataSet5";
            this.panaroDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "tipos";
            this.tiposBindingSource.DataSource = this.panaroDataSet4;
            // 
            // panaroDataSet4
            // 
            this.panaroDataSet4.DataSetName = "panaroDataSet4";
            this.panaroDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Finalizar comanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxnome
            // 
            this.txtboxnome.Enabled = false;
            this.txtboxnome.Location = new System.Drawing.Point(145, 12);
            this.txtboxnome.Name = "txtboxnome";
            this.txtboxnome.Size = new System.Drawing.Size(410, 20);
            this.txtboxnome.TabIndex = 10;
            // 
            // txtboxid
            // 
            this.txtboxid.Enabled = false;
            this.txtboxid.Location = new System.Drawing.Point(45, 12);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(50, 20);
            this.txtboxid.TabIndex = 11;
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // tiposTableAdapter1
            // 
            this.tiposTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtboxtotal
            // 
            this.txtboxtotal.Enabled = false;
            this.txtboxtotal.Location = new System.Drawing.Point(654, 120);
            this.txtboxtotal.Name = "txtboxtotal";
            this.txtboxtotal.Size = new System.Drawing.Size(111, 20);
            this.txtboxtotal.TabIndex = 14;
            this.txtboxtotal.TextChanged += new System.EventHandler(this.txtboxid_TextChanged);
            // 
            // panaroDataSet9
            // 
            this.panaroDataSet9.DataSetName = "panaroDataSet9";
            this.panaroDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.panaroDataSet9;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Somar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvcom
            // 
            this.dgvcom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcom.Location = new System.Drawing.Point(13, 89);
            this.dgvcom.Name = "dgvcom";
            this.dgvcom.Size = new System.Drawing.Size(542, 260);
            this.dgvcom.TabIndex = 16;
            this.dgvcom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcom_CellContentClick);
            // 
            // frmedcom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 390);
            this.ControlBox = false;
            this.Controls.Add(this.dgvcom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtboxtotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.txtboxnome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmedcom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar comanda";
            this.Load += new System.EventHandler(this.frmconsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxnome;
        private System.Windows.Forms.TextBox txtboxid;
        private panaroDataSet4 panaroDataSet4;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private panaroDataSet4TableAdapters.tiposTableAdapter tiposTableAdapter;
        private panaroDataSet5 panaroDataSet5;
        private System.Windows.Forms.BindingSource tiposBindingSource1;
        private panaroDataSet5TableAdapters.tiposTableAdapter tiposTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtboxtotal;
        private panaroDataSet9 panaroDataSet9;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private panaroDataSet9TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvcom;
    }
}