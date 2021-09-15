
namespace DongulerDeneme
{
    partial class deneme3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRastgeleSayilarOlustur = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(421, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 264);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rastgele 10 sayi ekleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRastgeleSayilarOlustur
            // 
            this.btnRastgeleSayilarOlustur.Location = new System.Drawing.Point(22, 52);
            this.btnRastgeleSayilarOlustur.Name = "btnRastgeleSayilarOlustur";
            this.btnRastgeleSayilarOlustur.Size = new System.Drawing.Size(182, 23);
            this.btnRastgeleSayilarOlustur.TabIndex = 2;
            this.btnRastgeleSayilarOlustur.Text = "Rastgele Sayilar";
            this.btnRastgeleSayilarOlustur.UseVisualStyleBackColor = true;
            this.btnRastgeleSayilarOlustur.Click += new System.EventHandler(this.btnRastgeleSayilarOlustur_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(210, 52);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(188, 23);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Text = "Dizideki Elemanlari Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            // 
            // deneme3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnRastgeleSayilarOlustur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "deneme3";
            this.Text = "deneme3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRastgeleSayilarOlustur;
        private System.Windows.Forms.Button btnTopla;
    }
}