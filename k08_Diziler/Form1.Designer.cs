
namespace k08_Diziler
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstTek = new System.Windows.Forms.ListBox();
            this.lstCift = new System.Windows.Forms.ListBox();
            this.btnTekCift = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
           
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(440, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 238);
            this.listBox1.TabIndex = 1;
            // 
            // lstTek
            // 
            this.lstTek.FormattingEnabled = true;
            this.lstTek.Location = new System.Drawing.Point(40, 66);
            this.lstTek.Name = "lstTek";
            this.lstTek.Size = new System.Drawing.Size(111, 95);
            this.lstTek.TabIndex = 2;
            // 
            // lstCift
            // 
            this.lstCift.FormattingEnabled = true;
            this.lstCift.Location = new System.Drawing.Point(187, 66);
            this.lstCift.Name = "lstCift";
            this.lstCift.Size = new System.Drawing.Size(120, 95);
            this.lstCift.TabIndex = 3;
            // 
            // btnTekCift
            // 
            this.btnTekCift.Location = new System.Drawing.Point(40, 167);
            this.btnTekCift.Name = "btnTekCift";
            this.btnTekCift.Size = new System.Drawing.Size(267, 23);
            this.btnTekCift.TabIndex = 4;
            this.btnTekCift.Text = "Tek ve Cift ekle";
            this.btnTekCift.UseVisualStyleBackColor = true;
            
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTekCift);
            this.Controls.Add(this.lstCift);
            this.Controls.Add(this.lstTek);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstTek;
        private System.Windows.Forms.ListBox lstCift;
        private System.Windows.Forms.Button btnTekCift;
        private System.Windows.Forms.Button button2;
    }
}

