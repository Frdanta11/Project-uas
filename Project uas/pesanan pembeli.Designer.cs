namespace Project_uas
{
    partial class pesanan_pembeli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDaftar = new System.Windows.Forms.Label();
            this.buttonSemua = new System.Windows.Forms.Button();
            this.buttonBelumDibayar = new System.Windows.Forms.Button();
            this.buttonSelesai = new System.Windows.Forms.Button();
            this.buttonDibatalkan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(233)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.buttonDibatalkan);
            this.panel1.Controls.Add(this.buttonSelesai);
            this.panel1.Controls.Add(this.buttonBelumDibayar);
            this.panel1.Controls.Add(this.buttonSemua);
            this.panel1.Controls.Add(this.labelDaftar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelDaftar
            // 
            this.labelDaftar.AutoSize = true;
            this.labelDaftar.Location = new System.Drawing.Point(3, 8);
            this.labelDaftar.Name = "labelDaftar";
            this.labelDaftar.Size = new System.Drawing.Size(121, 20);
            this.labelDaftar.TabIndex = 1;
            this.labelDaftar.Text = "Daftar Pesanan";
            // 
            // buttonSemua
            // 
            this.buttonSemua.AutoSize = true;
            this.buttonSemua.BackColor = System.Drawing.Color.Silver;
            this.buttonSemua.Location = new System.Drawing.Point(79, 70);
            this.buttonSemua.Name = "buttonSemua";
            this.buttonSemua.Size = new System.Drawing.Size(75, 30);
            this.buttonSemua.TabIndex = 1;
            this.buttonSemua.Text = "Semua";
            this.buttonSemua.UseVisualStyleBackColor = false;
            // 
            // buttonBelumDibayar
            // 
            this.buttonBelumDibayar.AutoSize = true;
            this.buttonBelumDibayar.BackColor = System.Drawing.Color.Silver;
            this.buttonBelumDibayar.Location = new System.Drawing.Point(248, 70);
            this.buttonBelumDibayar.Name = "buttonBelumDibayar";
            this.buttonBelumDibayar.Size = new System.Drawing.Size(122, 30);
            this.buttonBelumDibayar.TabIndex = 2;
            this.buttonBelumDibayar.Text = "Belum Dibayar";
            this.buttonBelumDibayar.UseVisualStyleBackColor = false;
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.AutoSize = true;
            this.buttonSelesai.BackColor = System.Drawing.Color.Silver;
            this.buttonSelesai.Location = new System.Drawing.Point(467, 70);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(75, 30);
            this.buttonSelesai.TabIndex = 1;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = false;
            // 
            // buttonDibatalkan
            // 
            this.buttonDibatalkan.AutoSize = true;
            this.buttonDibatalkan.BackColor = System.Drawing.Color.Silver;
            this.buttonDibatalkan.Location = new System.Drawing.Point(629, 70);
            this.buttonDibatalkan.Name = "buttonDibatalkan";
            this.buttonDibatalkan.Size = new System.Drawing.Size(95, 30);
            this.buttonDibatalkan.TabIndex = 1;
            this.buttonDibatalkan.Text = "Dibatalkan";
            this.buttonDibatalkan.UseVisualStyleBackColor = false;
            // 
            // pesanan_pembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "pesanan_pembeli";
            this.Text = "pesanan_pembeli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDaftar;
        private System.Windows.Forms.Button buttonDibatalkan;
        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.Button buttonBelumDibayar;
        private System.Windows.Forms.Button buttonSemua;
    }
}