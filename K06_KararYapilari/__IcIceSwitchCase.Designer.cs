
namespace K06_KararYapilari
{
    partial class __IcIceSwitchCase
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdim = new System.Windows.Forms.TextBox();
            this.txtParolam = new System.Windows.Forms.TextBox();
            this.btnGiriss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KullaniciAdiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parolaniz";
            // 
            // txtKullaniciAdim
            // 
            this.txtKullaniciAdim.Location = new System.Drawing.Point(282, 109);
            this.txtKullaniciAdim.Name = "txtKullaniciAdim";
            this.txtKullaniciAdim.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdim.TabIndex = 2;
            // 
            // txtParolam
            // 
            this.txtParolam.Location = new System.Drawing.Point(282, 171);
            this.txtParolam.Name = "txtParolam";
            this.txtParolam.Size = new System.Drawing.Size(100, 20);
            this.txtParolam.TabIndex = 3;
            // 
            // btnGiriss
            // 
            this.btnGiriss.Location = new System.Drawing.Point(288, 231);
            this.btnGiriss.Name = "btnGiriss";
            this.btnGiriss.Size = new System.Drawing.Size(75, 23);
            this.btnGiriss.TabIndex = 4;
            this.btnGiriss.Text = "Giris";
            this.btnGiriss.UseVisualStyleBackColor = true;
            this.btnGiriss.Click += new System.EventHandler(this.btnGiriss_Click);
            // 
            // __IcIceSwitchCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiriss);
            this.Controls.Add(this.txtParolam);
            this.Controls.Add(this.txtKullaniciAdim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "__IcIceSwitchCase";
            this.Text = "__IcIceSwitchCase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdim;
        private System.Windows.Forms.TextBox txtParolam;
        private System.Windows.Forms.Button btnGiriss;
    }
}