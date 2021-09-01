
namespace K06_KararYapilari
{
    partial class KitapciSiparis
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
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Sayisini giriniz";
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(71, 107);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapSayisi.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(70, 147);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(101, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(149, 220);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 4;
            // 
            // KitapciSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKitapSayisi);
            this.Controls.Add(this.label1);
            this.Name = "KitapciSiparis";
            this.Text = "KitapciSiparis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutar;
    }
}