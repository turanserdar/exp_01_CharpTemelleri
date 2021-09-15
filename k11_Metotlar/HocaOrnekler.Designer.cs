
namespace k11_Metotlar
{
    partial class HocaOrnekler
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
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.cmbSayilar = new System.Windows.Forms.ComboBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitis2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(41, 21);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(120, 303);
            this.lstSonuc.TabIndex = 0;
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(177, 21);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(177, 23);
            this.btnOrnek1.TabIndex = 1;
            this.btnOrnek1.Text = "1\'den 100\'e kadar listeye ekle";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(177, 50);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(177, 23);
            this.btnOrnek2.TabIndex = 2;
            this.btnOrnek2.Text = "Hem listeye hem cmb\'e ekle";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // cmbSayilar
            // 
            this.cmbSayilar.FormattingEnabled = true;
            this.cmbSayilar.Location = new System.Drawing.Point(177, 79);
            this.cmbSayilar.Name = "cmbSayilar";
            this.cmbSayilar.Size = new System.Drawing.Size(177, 21);
            this.cmbSayilar.TabIndex = 3;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(177, 131);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(177, 20);
            this.txtBitis.TabIndex = 4;
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(177, 157);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(177, 23);
            this.btnOrnek3.TabIndex = 5;
            this.btnOrnek3.Text = "Bitise Kadar Dongu Kur";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Location = new System.Drawing.Point(177, 265);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(177, 23);
            this.btnOrnek4.TabIndex = 6;
            this.btnOrnek4.Text = "Dongu Kur";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.btnOrnek4_Click);
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(177, 218);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(177, 20);
            this.txtBaslangic.TabIndex = 7;
            // 
            // txtBitis2
            // 
            this.txtBitis2.Location = new System.Drawing.Point(177, 244);
            this.txtBitis2.Name = "txtBitis2";
            this.txtBitis2.Size = new System.Drawing.Size(177, 20);
            this.txtBitis2.TabIndex = 8;
            // 
            // HocaOrnekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBitis2);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.cmbSayilar);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.lstSonuc);
            this.Name = "HocaOrnekler";
            this.Text = "HocaOrnekler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.ComboBox cmbSayilar;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnOrnek4;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtBitis2;
    }
}