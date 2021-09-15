
namespace DongulerDeneme
{
    partial class OdevDeneme
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
            this.txtKarakterSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.chbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chbKucukHarf = new System.Windows.Forms.CheckBox();
            this.chbRakam = new System.Windows.Forms.CheckBox();
            this.chbSembol = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSifreler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtKarakterSayisi
            // 
            this.txtKarakterSayisi.Location = new System.Drawing.Point(199, 23);
            this.txtKarakterSayisi.Name = "txtKarakterSayisi";
            this.txtKarakterSayisi.Size = new System.Drawing.Size(40, 20);
            this.txtKarakterSayisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kac Karakterli Bir Sifre Istiyorsun?";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(30, 144);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(209, 57);
            this.btnOlustur.TabIndex = 4;
            this.btnOlustur.Text = "Olustur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // chbBuyukHarf
            // 
            this.chbBuyukHarf.AutoSize = true;
            this.chbBuyukHarf.Location = new System.Drawing.Point(31, 52);
            this.chbBuyukHarf.Name = "chbBuyukHarf";
            this.chbBuyukHarf.Size = new System.Drawing.Size(160, 17);
            this.chbBuyukHarf.TabIndex = 5;
            this.chbBuyukHarf.Text = "Buyuk Harf Dahil Olsun Mu?";
            this.chbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chbKucukHarf
            // 
            this.chbKucukHarf.AutoSize = true;
            this.chbKucukHarf.Location = new System.Drawing.Point(30, 75);
            this.chbKucukHarf.Name = "chbKucukHarf";
            this.chbKucukHarf.Size = new System.Drawing.Size(161, 17);
            this.chbKucukHarf.TabIndex = 6;
            this.chbKucukHarf.Text = "Kucuk Harf Dahil Olsun Mu?";
            this.chbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chbRakam
            // 
            this.chbRakam.AutoSize = true;
            this.chbRakam.Location = new System.Drawing.Point(31, 121);
            this.chbRakam.Name = "chbRakam";
            this.chbRakam.Size = new System.Drawing.Size(141, 17);
            this.chbRakam.TabIndex = 7;
            this.chbRakam.Text = "Rakam Dahil Olsun Mu?";
            this.chbRakam.UseVisualStyleBackColor = true;
            // 
            // chbSembol
            // 
            this.chbSembol.AutoSize = true;
            this.chbSembol.Location = new System.Drawing.Point(30, 98);
            this.chbSembol.Name = "chbSembol";
            this.chbSembol.Size = new System.Drawing.Size(142, 17);
            this.chbSembol.TabIndex = 8;
            this.chbSembol.Text = "Sembol Dahil Olsun Mu?";
            this.chbSembol.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sifreler";
            // 
            // lstSifreler
            // 
            this.lstSifreler.FormattingEnabled = true;
            this.lstSifreler.Location = new System.Drawing.Point(31, 220);
            this.lstSifreler.Name = "lstSifreler";
            this.lstSifreler.Size = new System.Drawing.Size(208, 95);
            this.lstSifreler.TabIndex = 10;
            // 
            // OdevDeneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.lstSifreler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbSembol);
            this.Controls.Add(this.chbRakam);
            this.Controls.Add(this.chbKucukHarf);
            this.Controls.Add(this.chbBuyukHarf);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKarakterSayisi);
            this.Name = "OdevDeneme";
            this.Text = "OdevDeneme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKarakterSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.CheckBox chbBuyukHarf;
        private System.Windows.Forms.CheckBox chbKucukHarf;
        private System.Windows.Forms.CheckBox chbRakam;
        private System.Windows.Forms.CheckBox chbSembol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSifreler;
    }
}