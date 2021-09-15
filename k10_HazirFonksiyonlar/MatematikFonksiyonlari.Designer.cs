
namespace k10_HazirFonksiyonlar
{
    partial class MatematikFonksiyonlari
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.btnEnBuyuk = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(259, 83);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(404, 42);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(100, 20);
            this.txtGiris.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yaricap giriniz";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(424, 88);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(25, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "___";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(488, 138);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(232, 20);
            this.txtSayi1.TabIndex = 4;
            this.txtSayi1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(488, 164);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(232, 20);
            this.txtSayi2.TabIndex = 5;
            // 
            // txtSayi3
            // 
            this.txtSayi3.Location = new System.Drawing.Point(488, 190);
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(232, 20);
            this.txtSayi3.TabIndex = 6;
            this.txtSayi3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnEnBuyuk
            // 
            this.btnEnBuyuk.Location = new System.Drawing.Point(488, 225);
            this.btnEnBuyuk.Name = "btnEnBuyuk";
            this.btnEnBuyuk.Size = new System.Drawing.Size(232, 23);
            this.btnEnBuyuk.TabIndex = 7;
            this.btnEnBuyuk.Text = "En buyugunu bul";
            this.btnEnBuyuk.UseVisualStyleBackColor = true;
            this.btnEnBuyuk.Click += new System.EventHandler(this.btnEnBuyuk_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(67, 40);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(75, 23);
            this.btnPi.TabIndex = 8;
            this.btnPi.Text = "PI";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ABS()";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.Location = new System.Drawing.Point(67, 98);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(75, 23);
            this.btnCeiling.TabIndex = 10;
            this.btnCeiling.Text = "Ceiling()";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(67, 127);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(75, 23);
            this.btnFloor.TabIndex = 11;
            this.btnFloor.Text = "Floor()";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Round()";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MatematikFonksiyonlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnEnBuyuk);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.btnHesapla);
            this.Name = "MatematikFonksiyonlari";
            this.Text = "MatematikFonksiyonlari";
            this.Load += new System.EventHandler(this.MatematikFonksiyonlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.Button btnEnBuyuk;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCeiling;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button button2;
    }
}