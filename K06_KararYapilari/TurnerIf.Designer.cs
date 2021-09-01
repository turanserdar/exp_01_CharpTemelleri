
namespace K06_KararYapilari
{
    partial class TurnerIf
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnTekCift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir Sayi Giriniz";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(115, 143);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 1;
            // 
            // btnTekCift
            // 
            this.btnTekCift.Location = new System.Drawing.Point(115, 184);
            this.btnTekCift.Name = "btnTekCift";
            this.btnTekCift.Size = new System.Drawing.Size(100, 23);
            this.btnTekCift.TabIndex = 2;
            this.btnTekCift.Text = "Tek mi Cift mi?";
            this.btnTekCift.UseVisualStyleBackColor = true;
            this.btnTekCift.Click += new System.EventHandler(this.btnTekCift_Click);
            // 
            // TurnerIf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTekCift);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Name = "TurnerIf";
            this.Text = "TurnerIf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnTekCift;
    }
}