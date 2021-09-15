
namespace DongulerDeneme
{
    partial class Form4
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
            this.btn1100 = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSecilenYil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1100
            // 
            this.btn1100.Location = new System.Drawing.Point(43, 12);
            this.btn1100.Name = "btn1100";
            this.btn1100.Size = new System.Drawing.Size(75, 23);
            this.btn1100.TabIndex = 0;
            this.btn1100.Text = "button1";
            this.btn1100.UseVisualStyleBackColor = true;
            this.btn1100.Click += new System.EventHandler(this.btn1100_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(354, 21);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(195, 238);
            this.lstSonuc.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSecilenYil
            // 
            this.txtSecilenYil.Location = new System.Drawing.Point(43, 175);
            this.txtSecilenYil.Name = "txtSecilenYil";
            this.txtSecilenYil.Size = new System.Drawing.Size(180, 20);
            this.txtSecilenYil.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSecilenYil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btn1100);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1100;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSecilenYil;
    }
}