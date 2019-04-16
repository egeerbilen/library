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
    public partial class ÖğrenciFormu : Form
    {
        public ÖğrenciFormu()
        {
            InitializeComponent();
        }

        public static string GönderKullanıcı;
        public static string GönderSifre;
        public string Okuma = @"C:\Users\Ege\Desktop\Kütüpane\Öğrenci.txt";
        int i = 0;
        string[] Veriler = new string[100];
        bool GirişKontrol = false;
        bool Kontrol = false;
        private void button3_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < 100; c++)
            {
                if (Kontrol != true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {

                        using (StreamReader Oku = new StreamReader(Okuma))
                        {
                            string Line = String.Empty;
                            while ((Line = Oku.ReadLine()) != null && i < 100)
                            {
                                Veriler[i] = Line;
                                i++;
                                if (GirişKontrol != true)
                                {
                                    if (Veriler[0] == textBox1.Text && Veriler[1] == textBox2.Text)
                                    {
                                        MessageBox.Show("Giriş başarılı");
                                        Kitapİçerik Kitap = new Kitapİçerik();
                                        Kitap.Show();
                                        this.Hide();
                                        GirişKontrol = true;
                                        Kontrol = true;
                                    }
                                }
                                if (i == 2)
                                {
                                    i = 0;
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Girdiniz bilgileri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    

    }

}
