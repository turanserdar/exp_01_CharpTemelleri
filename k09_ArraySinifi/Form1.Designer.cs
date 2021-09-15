
namespace k09_ArraySinifi
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(121, 42);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(142, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy()";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(121, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear()";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(121, 100);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(142, 23);
            this.btnIndexOf.TabIndex = 2;
            this.btnIndexOf.Text = "IndexOf()";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(121, 129);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(142, 23);
            this.btnLastIndexOf.TabIndex = 3;
            this.btnLastIndexOf.Text = "LastIndexOf()";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(121, 158);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(142, 23);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Reverse() Metodu";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(121, 187);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(142, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort()";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(121, 216);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(142, 23);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "Resize()";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(447, 57);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(241, 160);
            this.lstSonuc.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.ListBox lstSonuc;
    }
}

