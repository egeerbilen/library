namespace Kütüpane
{
    partial class FormPersonel
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
            this.txtKullanıcıSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.lblKullanıcıSifre = new System.Windows.Forms.Label();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullanıcıSifre
            // 
            this.txtKullanıcıSifre.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıSifre.Location = new System.Drawing.Point(201, 140);
            this.txtKullanıcıSifre.Name = "txtKullanıcıSifre";
            this.txtKullanıcıSifre.Size = new System.Drawing.Size(100, 35);
            this.txtKullanıcıSifre.TabIndex = 57;
            this.txtKullanıcıSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcı.Location = new System.Drawing.Point(201, 104);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(100, 35);
            this.txtKullanıcı.TabIndex = 56;
            // 
            // lblKullanıcıSifre
            // 
            this.lblKullanıcıSifre.AutoSize = true;
            this.lblKullanıcıSifre.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıSifre.Location = new System.Drawing.Point(36, 143);
            this.lblKullanıcıSifre.Name = "lblKullanıcıSifre";
            this.lblKullanıcıSifre.Size = new System.Drawing.Size(76, 29);
            this.lblKullanıcıSifre.TabIndex = 55;
            this.lblKullanıcıSifre.Text = "Şifre";
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcı.Location = new System.Drawing.Point(26, 107);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(128, 29);
            this.lblKullanıcı.TabIndex = 54;
            this.lblKullanıcı.Text = "Kullanıcı";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(201, 181);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 44);
            this.btnGiris.TabIndex = 53;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 58;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(319, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtKullanıcıSifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.lblKullanıcıSifre);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.btnGiris);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullanıcıSifre;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.Label lblKullanıcıSifre;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button button2;
    }
}