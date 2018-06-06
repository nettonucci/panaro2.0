namespace Panaro
{
    partial class frmcaixa
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
            this.dgvcaixa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcaixa
            // 
            this.dgvcaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcaixa.Location = new System.Drawing.Point(56, 213);
            this.dgvcaixa.Name = "dgvcaixa";
            this.dgvcaixa.Size = new System.Drawing.Size(443, 150);
            this.dgvcaixa.TabIndex = 0;
            // 
            // frmcaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvcaixa);
            this.Name = "frmcaixa";
            this.Text = "frmcaixa";
            this.Load += new System.EventHandler(this.frmcaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcaixa;
    }
}