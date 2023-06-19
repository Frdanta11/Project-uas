namespace Project_uas
{
    partial class keranjang
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
            this.labelKeranjang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKeranjang
            // 
            this.labelKeranjang.AutoSize = true;
            this.labelKeranjang.Location = new System.Drawing.Point(12, 9);
            this.labelKeranjang.Name = "labelKeranjang";
            this.labelKeranjang.Size = new System.Drawing.Size(81, 20);
            this.labelKeranjang.TabIndex = 0;
            this.labelKeranjang.Text = "Keranjang";
            // 
            // keranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKeranjang);
            this.Name = "keranjang";
            this.Text = "keranjang";
            this.Load += new System.EventHandler(this.keranjang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeranjang;
    }
}