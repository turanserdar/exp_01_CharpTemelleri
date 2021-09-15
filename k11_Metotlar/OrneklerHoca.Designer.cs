
namespace k11_Metotlar
{
    partial class btnOrnek1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.cmbSayilar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(36, 24);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(120, 303);
            this.lstSonuc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1\'den 100\'e kadar listeye ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(172, 53);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(190, 23);
            this.btnOrnek2.TabIndex = 2;
            this.btnOrnek2.Text = "Hem listeye hem cmb\'e ekle";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // cmbSayilar
            // 
            this.cmbSayilar.FormattingEnabled = true;
            this.cmbSayilar.Location = new System.Drawing.Point(172, 82);
            this.cmbSayilar.Name = "cmbSayilar";
            this.cmbSayilar.Size = new System.Drawing.Size(190, 21);
            this.cmbSayilar.TabIndex = 3;
            // 
            // btnOrnek1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSayilar);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSonuc);
            this.Name = "btnOrnek1";
            this.Text = "OrneklerHoca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.ComboBox cmbSayilar;
    }
}