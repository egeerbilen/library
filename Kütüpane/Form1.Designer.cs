namespace Kütüpane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPersonelGiriş = new System.Windows.Forms.Button();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.lblSistemYazısı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(271, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(285, 158);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnPersonelGiriş
            // 
            this.btnPersonelGiriş.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiriş.Location = new System.Drawing.Point(382, 295);
            this.btnPersonelGiriş.Name = "btnPersonelGiriş";
            this.btnPersonelGiriş.Size = new System.Drawing.Size(349, 62);
            this.btnPersonelGiriş.TabIndex = 46;
            this.btnPersonelGiriş.Text = "Personel giriş";
            this.btnPersonelGiriş.UseVisualStyleBackColor = true;
            this.btnPersonelGiriş.Click += new System.EventHandler(this.btnPersonelGiriş_Click);
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGiris.Location = new System.Drawing.Point(382, 363);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(349, 62);
            this.btnOgrenciGiris.TabIndex = 60;
            this.btnOgrenciGiris.Text = "Öğrenci giriş";
            this.btnOgrenciGiris.UseVisualStyleBackColor = true;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // lblUyarı
            // 
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.Font = new System.Drawing.Font("Verdana", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.Location = new System.Drawing.Point(302, 232);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(490, 52);
            this.lblUyarı.TabIndex = 61;
            this.lblUyarı.Text = "Lütfen giriş yapınız";
            // 
            // lblSistemYazısı
            // 
            this.lblSistemYazısı.AutoSize = true;
            this.lblSistemYazısı.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemYazısı.Location = new System.Drawing.Point(90, 428);
            this.lblSistemYazısı.Name = "lblSistemYazısı";
            this.lblSistemYazısı.Size = new System.Drawing.Size(914, 36);
            this.lblSistemYazısı.TabIndex = 62;
            this.lblSistemYazısı.Text = "Kırıkkale Üniversitesi kütüpane sistemine hoşgeldiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 519);
            this.Controls.Add(this.lblSistemYazısı);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Controls.Add(this.btnPersonelGiriş);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnPersonelGiriş;
        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.Label lblSistemYazısı;
    }
}

