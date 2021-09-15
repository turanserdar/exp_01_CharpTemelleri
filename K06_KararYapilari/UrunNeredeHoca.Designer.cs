
namespace K06_KararYapilari
{
    partial class UrunNeredeHoca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunNerede = new System.Windows.Forms.Button();
            this.lblReyon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aradigin Urunun Ismini Gir";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(104, 150);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // btnUrunNerede
            // 
            this.btnUrunNerede.Location = new System.Drawing.Point(104, 189);
            this.btnUrunNerede.Name = "btnUrunNerede";
            this.btnUrunNerede.Size = new System.Drawing.Size(143, 29);
            this.btnUrunNerede.TabIndex = 2;
            this.btnUrunNerede.Text = "UrunNerede";
            this.btnUrunNerede.UseVisualStyleBackColor = true;
            this.btnUrunNerede.Click += new System.EventHandler(this.btnUrunNerede_Click);
            // 
            // lblReyon
            // 
            this.lblReyon.AutoSize = true;
            this.lblReyon.Location = new System.Drawing.Point(137, 265);
            this.lblReyon.Name = "lblReyon";
            this.lblReyon.Size = new System.Drawing.Size(25, 13);
            this.lblReyon.TabIndex = 3;
            this.lblReyon.Text = "___";
            // 
            // UrunNeredeHoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReyon);
            this.Controls.Add(this.btnUrunNerede);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Name = "UrunNeredeHoca";
            this.Text = "UrunNeredeHoca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnUrunNerede;
        private System.Windows.Forms.Label lblReyon;
    }
}