
namespace k11_Metotlar
{
    partial class Ornekler2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSayilar = new System.Windows.Forms.ComboBox();
            this.btnRastgeleSayi = new System.Windows.Forms.Button();
            this.txtRastgeleSayi = new System.Windows.Forms.TextBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnDefaultDeger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(76, 246);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(183, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 212);
            this.listBox1.TabIndex = 2;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(60, 169);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kac sayi uretmek istiyorsun";
            // 
            // cmbSayilar
            // 
            this.cmbSayilar.FormattingEnabled = true;
            this.cmbSayilar.Location = new System.Drawing.Point(386, 104);
            this.cmbSayilar.Name = "cmbSayilar";
            this.cmbSayilar.Size = new System.Drawing.Size(121, 21);
            this.cmbSayilar.TabIndex = 5;
            // 
            // btnRastgeleSayi
            // 
            this.btnRastgeleSayi.Location = new System.Drawing.Point(386, 64);
            this.btnRastgeleSayi.Name = "btnRastgeleSayi";
            this.btnRastgeleSayi.Size = new System.Drawing.Size(121, 23);
            this.btnRastgeleSayi.TabIndex = 6;
            this.btnRastgeleSayi.Text = "Ekle";
            this.btnRastgeleSayi.UseVisualStyleBackColor = true;
            this.btnRastgeleSayi.Click += new System.EventHandler(this.btnRastgeleSayi_Click);
            // 
            // txtRastgeleSayi
            // 
            this.txtRastgeleSayi.Location = new System.Drawing.Point(386, 38);
            this.txtRastgeleSayi.Name = "txtRastgeleSayi";
            this.txtRastgeleSayi.Size = new System.Drawing.Size(121, 20);
            this.txtRastgeleSayi.TabIndex = 7;
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(386, 195);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(121, 23);
            this.btnRef.TabIndex = 8;
            this.btnRef.Text = "Ref()";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnDefaultDeger
            // 
            this.btnDefaultDeger.Location = new System.Drawing.Point(386, 246);
            this.btnDefaultDeger.Name = "btnDefaultDeger";
            this.btnDefaultDeger.Size = new System.Drawing.Size(121, 23);
            this.btnDefaultDeger.TabIndex = 9;
            this.btnDefaultDeger.Text = "Default Deger";
            this.btnDefaultDeger.UseVisualStyleBackColor = true;
            this.btnDefaultDeger.Click += new System.EventHandler(this.btnDefaultDeger_Click);
            // 
            // Ornekler2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDefaultDeger);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.txtRastgeleSayi);
            this.Controls.Add(this.btnRastgeleSayi);
            this.Controls.Add(this.cmbSayilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.button1);
            this.Name = "Ornekler2";
            this.Text = "Ornekler2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSayilar;
        private System.Windows.Forms.Button btnRastgeleSayi;
        private System.Windows.Forms.TextBox txtRastgeleSayi;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDefaultDeger;
    }
}