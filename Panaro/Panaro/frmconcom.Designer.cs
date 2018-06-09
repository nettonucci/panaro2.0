namespace Panaro
{
    partial class frmconcom
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
            this.comandasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCom = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comandasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // comandasBindingSource
            // 
            this.comandasBindingSource.DataMember = "comandas";
            // 
            // dgvComanda
            // 
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Location = new System.Drawing.Point(12, 123);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.Size = new System.Drawing.Size(362, 150);
            this.dgvComanda.TabIndex = 0;
            this.dgvComanda.DoubleClick += new System.EventHandler(this.dgvComanda_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comanda:";
            // 
            // txtboxCom
            // 
            this.txtboxCom.Enabled = false;
            this.txtboxCom.Location = new System.Drawing.Point(73, 6);
            this.txtboxCom.Name = "txtboxCom";
            this.txtboxCom.Size = new System.Drawing.Size(175, 20);
            this.txtboxCom.TabIndex = 2;
            this.txtboxCom.TextChanged += new System.EventHandler(this.txtboxCom_TextChanged);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(15, 71);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(91, 23);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar comanda";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(254, 6);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(47, 20);
            this.txtboxid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione abaixo uma comanda para ediçao";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmconcom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 290);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtboxCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmconcom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Comanda";
            this.Load += new System.EventHandler(this.teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comandasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private panaroDataSet8 panaroDataSet8;
        private System.Windows.Forms.BindingSource comandasBindingSource;
        private panaroDataSet8TableAdapters.comandasTableAdapter comandasTableAdapter;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCom;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}