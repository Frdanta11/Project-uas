namespace Project_uas
{
    partial class beranda
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
            this.panelBeranda = new System.Windows.Forms.Panel();
            this.pictureBoxHomecatering = new System.Windows.Forms.PictureBox();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.buttonPesanan = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelBeranda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomecatering)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBeranda
            // 
            this.panelBeranda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.panelBeranda.Controls.Add(this.buttonDaftar);
            this.panelBeranda.Controls.Add(this.pictureBoxHomecatering);
            this.panelBeranda.Controls.Add(this.buttonHome);
            this.panelBeranda.Controls.Add(this.buttonPesanan);
            this.panelBeranda.Location = new System.Drawing.Point(0, -1);
            this.panelBeranda.Name = "panelBeranda";
            this.panelBeranda.Size = new System.Drawing.Size(799, 124);
            this.panelBeranda.TabIndex = 0;
            // 
            // pictureBoxHomecatering
            // 
            this.pictureBoxHomecatering.Image = global::Project_uas.Properties.Resources.homecatering_removebg_preview__1_;
            this.pictureBoxHomecatering.Location = new System.Drawing.Point(208, -38);
            this.pictureBoxHomecatering.Name = "pictureBoxHomecatering";
            this.pictureBoxHomecatering.Size = new System.Drawing.Size(241, 188);
            this.pictureBoxHomecatering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomecatering.TabIndex = 0;
            this.pictureBoxHomecatering.TabStop = false;
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.AutoSize = true;
            this.buttonDaftar.BackColor = System.Drawing.Color.Transparent;
            this.buttonDaftar.Location = new System.Drawing.Point(12, 85);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(118, 30);
            this.buttonDaftar.TabIndex = 3;
            this.buttonDaftar.Text = "Daftar Produk";
            this.buttonDaftar.UseVisualStyleBackColor = false;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // buttonPesanan
            // 
            this.buttonPesanan.AutoSize = true;
            this.buttonPesanan.Location = new System.Drawing.Point(12, 49);
            this.buttonPesanan.Name = "buttonPesanan";
            this.buttonPesanan.Size = new System.Drawing.Size(118, 30);
            this.buttonPesanan.TabIndex = 2;
            this.buttonPesanan.Text = "Pesanan";
            this.buttonPesanan.UseVisualStyleBackColor = true;
            this.buttonPesanan.Click += new System.EventHandler(this.buttonPesanan_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Location = new System.Drawing.Point(12, 13);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(118, 30);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.panelBeranda);
            this.Name = "beranda";
            this.Text = "Home Catering";
            this.panelBeranda.ResumeLayout(false);
            this.panelBeranda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomecatering)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBeranda;
        private System.Windows.Forms.PictureBox pictureBoxHomecatering;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.Button buttonPesanan;
    }
}