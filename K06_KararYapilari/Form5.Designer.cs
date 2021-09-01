
namespace K06_KararYapilari
{
    partial class Form5
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
            this.txtMevsim = new System.Windows.Forms.TextBox();
            this.btnAylariGetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.btnMevsimGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir Mevsim Giriniz";
            // 
            // txtMevsim
            // 
            this.txtMevsim.Location = new System.Drawing.Point(57, 75);
            this.txtMevsim.Name = "txtMevsim";
            this.txtMevsim.Size = new System.Drawing.Size(100, 20);
            this.txtMevsim.TabIndex = 1;
            // 
            // btnAylariGetir
            // 
            this.btnAylariGetir.Location = new System.Drawing.Point(57, 121);
            this.btnAylariGetir.Name = "btnAylariGetir";
            this.btnAylariGetir.Size = new System.Drawing.Size(100, 23);
            this.btnAylariGetir.TabIndex = 2;
            this.btnAylariGetir.Text = "Aylari Getir";
            this.btnAylariGetir.UseVisualStyleBackColor = true;
            this.btnAylariGetir.Click += new System.EventHandler(this.btnAylariGetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bir Ay Giriniz";
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(313, 75);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(100, 20);
            this.txtAy.TabIndex = 4;
            // 
            // btnMevsimGetir
            // 
            this.btnMevsimGetir.Location = new System.Drawing.Point(313, 121);
            this.btnMevsimGetir.Name = "btnMevsimGetir";
            this.btnMevsimGetir.Size = new System.Drawing.Size(100, 23);
            this.btnMevsimGetir.TabIndex = 5;
            this.btnMevsimGetir.Text = "Mevsim Getir";
            this.btnMevsimGetir.UseVisualStyleBackColor = true;
            this.btnMevsimGetir.Click += new System.EventHandler(this.btnMevsimGetir_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMevsimGetir);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAylariGetir);
            this.Controls.Add(this.txtMevsim);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMevsim;
        private System.Windows.Forms.Button btnAylariGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.Button btnMevsimGetir;
    }
}