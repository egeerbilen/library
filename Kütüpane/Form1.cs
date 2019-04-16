using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Kütüpane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            ÖğrenciFormu Öğrenci = new ÖğrenciFormu();
            Öğrenci.Show();
            this.Hide();
        }

        private void btnPersonelGiriş_Click(object sender, EventArgs e)
        {
            FormPersonel Personel = new FormPersonel();
            Personel.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.URL = @"C:\Users\Ege\Desktop\Kütüpane\kkuTanıtım.mp4";
        }
    }
}
