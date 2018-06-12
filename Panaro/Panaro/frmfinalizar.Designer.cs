namespace Panaro
{
    partial class frmfinalizar
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
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.txtboxtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxdescr = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxtotal2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboforma = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbreais = new System.Windows.Forms.RadioButton();
            this.rdbporc = new System.Windows.Forms.RadioButton();
            this.txtboxdescp = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(93, 322);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(114, 23);
            this.btnfinalizar.TabIndex = 0;
            this.btnfinalizar.Text = "Finalizar comanda";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxid
            // 
            this.txtboxid.Enabled = false;
            this.txtboxid.Location = new System.Drawing.Point(12, 12);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(71, 20);
            this.txtboxid.TabIndex = 1;
            // 
            // txtboxtotal
            // 
            this.txtboxtotal.Enabled = false;
            this.txtboxtotal.Location = new System.Drawing.Point(104, 54);
            this.txtboxtotal.Name = "txtboxtotal";
            this.txtboxtotal.Size = new System.Drawing.Size(100, 20);
            this.txtboxtotal.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL R$:";
            // 
            // txtboxnome
            // 
            this.txtboxnome.Enabled = false;
            this.txtboxnome.Location = new System.Drawing.Point(98, 12);
            this.txtboxnome.Name = "txtboxnome";
            this.txtboxnome.Size = new System.Drawing.Size(201, 20);
            this.txtboxnome.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desconto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxdescr
            // 
            this.txtboxdescr.Location = new System.Drawing.Point(18, 134);
            this.txtboxdescr.Name = "txtboxdescr";
            this.txtboxdescr.Size = new System.Drawing.Size(100, 20);
            this.txtboxdescr.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total com desconto:";
            // 
            // txtboxtotal2
            // 
            this.txtboxtotal2.Enabled = false;
            this.txtboxtotal2.Location = new System.Drawing.Point(162, 221);
            this.txtboxtotal2.Name = "txtboxtotal2";
            this.txtboxtotal2.Size = new System.Drawing.Size(100, 20);
            this.txtboxtotal2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Forma de pagamento:";
            // 
            // comboforma
            // 
            this.comboforma.FormattingEnabled = true;
            this.comboforma.Items.AddRange(new object[] {
            "A vista",
            "Cartao de credito",
            "Cartao de debito"});
            this.comboforma.Location = new System.Drawing.Point(170, 266);
            this.comboforma.Name = "comboforma";
            this.comboforma.Size = new System.Drawing.Size(121, 21);
            this.comboforma.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rdbreais
            // 
            this.rdbreais.AutoSize = true;
            this.rdbreais.Location = new System.Drawing.Point(124, 135);
            this.rdbreais.Name = "rdbreais";
            this.rdbreais.Size = new System.Drawing.Size(52, 17);
            this.rdbreais.TabIndex = 19;
            this.rdbreais.TabStop = true;
            this.rdbreais.Text = "Reais";
            this.rdbreais.UseVisualStyleBackColor = true;
            this.rdbreais.CheckedChanged += new System.EventHandler(this.rdbreais_CheckedChanged);
            // 
            // rdbporc
            // 
            this.rdbporc.AutoSize = true;
            this.rdbporc.Location = new System.Drawing.Point(124, 161);
            this.rdbporc.Name = "rdbporc";
            this.rdbporc.Size = new System.Drawing.Size(88, 17);
            this.rdbporc.TabIndex = 21;
            this.rdbporc.TabStop = true;
            this.rdbporc.Text = "Porcentagem";
            this.rdbporc.UseVisualStyleBackColor = true;
            this.rdbporc.CheckedChanged += new System.EventHandler(this.rdbporc_CheckedChanged);
            // 
            // txtboxdescp
            // 
            this.txtboxdescp.Location = new System.Drawing.Point(18, 160);
            this.txtboxdescp.Name = "txtboxdescp";
            this.txtboxdescp.Size = new System.Drawing.Size(100, 20);
            this.txtboxdescp.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmfinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 370);
            this.Controls.Add(this.rdbporc);
            this.Controls.Add(this.txtboxdescp);
            this.Controls.Add(this.rdbreais);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboforma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxtotal2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxdescr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxtotal);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.btnfinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmfinalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmfinalizar";
            this.Load += new System.EventHandler(this.frmfinalizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.TextBox txtboxtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxdescr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxtotal2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboforma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbreais;
        private System.Windows.Forms.RadioButton rdbporc;
        private System.Windows.Forms.TextBox txtboxdescp;
        private System.Windows.Forms.Timer timer1;
    }
}