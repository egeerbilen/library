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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        public static string ÖgrenciAdGönder;
        public static string OgrenciSoyadGönder;
        public static string OgrenciNoGönder;
        public static string KitapAdGönder;
        public static string KitapAdetGönder;
        public static int ZamanıGetir;


        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        List<string> KitapArama = new List<string>();
        Olasılıksız olasılıksız = new Olasılıksız();
        Magisterium magisterium = new Magisterium();
        GaziMustafaKemalATATÜRK gaziMustafaKemalATATÜRK = new GaziMustafaKemalATATÜRK();
        AşkVeÖzgürlük aşkVeÖzgürlük = new AşkVeÖzgürlük();
        TanrıİnsandaUyurİnsandaUyanır tanrıİnsandaUyurİnsandaUyanır = new TanrıİnsandaUyurİnsandaUyanır();

        private void Personel_Load(object sender, EventArgs e)
        {

            KitapArama.Add(olasılıksız.kitabınAdı + "   " + olasılıksız.KitabınYazarı);
            KitapArama.Add(magisterium.kitabınAdı + "   " + magisterium.KitabınYazarı);
            KitapArama.Add(gaziMustafaKemalATATÜRK.kitabınAdı + "   " + gaziMustafaKemalATATÜRK.KitabınYazarı);
            KitapArama.Add(aşkVeÖzgürlük.kitabınAdı + "   " + aşkVeÖzgürlük.KitabınYazarı);
            KitapArama.Add(tanrıİnsandaUyurİnsandaUyanır.kitabınAdı + "   " + tanrıİnsandaUyurİnsandaUyanır.KitabınYazarı);

            for (int i = 1; i <= 31; i++)
            {
                cmbKitapUzatmaGünü.Items.Add(i);
            }
        }
        int KitapKiralamaÜcreti = 5;
        int ToplamVerilenKitap = 0;
        int GerialınanKitaplar;
        int MüşteriÖdenecek;
        int ToplamCiro;
        int KitapTarihiUzatma;
        int k = 0;
        int sayi;
        int KitapAdeti;
        public static int[] DiziÖğrenciNo = new int[100];
        public static string[] DiziÖğrenciAd = new string[100];
        public static string[] DiziÖğrenciSoyad = new string[100];
        public static string[] DiziKitapAdı = new string[1000];
        public static int[] DiziKitapAdet = new int[100];
        public static int[] DaTeAlışTarihiSaklama = new int[100];
        string DosyaPath = @"C:\Users\Ege\Desktop\Kütüpane\Veri.txt";
        string Dosya = @"C:\Users\Ege\Desktop\Kütüpane\Veri2.txt";

        DateTime YirmiGünsonra = DateTime.Now.AddDays(20);

        private void btnKitapver_Click(object sender, EventArgs e)
        {
            if (txtKitapAd.Text != "" && txtKitapAdet.Text != "" && txtOgrenciad.Text != "" && txtOgrenciSoyad.Text != "" && txtOgrenciNo.Text != "" && int.TryParse((txtKitapAdet.Text), out sayi) && int.TryParse((txtOgrenciNo.Text), out sayi))
            {
                KitapAdeti = Convert.ToInt32(txtKitapAdet.Text);

                if (progressBar1.Value >= 99)
                {
                    progressBar1.Value = 0;
                    MessageBox.Show("Bu kitap hediyedir", "Hediye", MessageBoxButtons.OK);
                }
                if (Convert.ToInt16(txtKitapAdet.Text) > 0)
                {
                    progressBar1.Value += 1;
                    if (chcKirala.Checked == true)
                    {
                        lstbAlıcıKitapAdet.Items.Add(txtKitapAdet.Text + "(Kiralık)");

                        MüşteriÖdenecek = KitapKiralamaÜcreti * KitapAdeti;
                        lblMüşteriÖdencek.Text = MüşteriÖdenecek.ToString();
                        ToplamCiro += MüşteriÖdenecek;

                        lblDurum.Text = "Kitap kiralandı";
                    }
                    else
                    {
                        lstbAlıcıKitapAdet.Items.Add(txtKitapAdet.Text);

                        lblDurum.Text = "Kitap verildi";
                    }

                    DiziKitapAdet[k] = Convert.ToInt32(txtKitapAdet.Text);

                    lstbAlıcıAd.Items.Add(txtOgrenciad.Text);
                    DiziÖğrenciAd[k] = txtOgrenciad.Text;

                    lstbAlıcıSoyad.Items.Add(txtOgrenciSoyad.Text);
                    DiziÖğrenciSoyad[k] = txtOgrenciSoyad.Text;

                    lstbAlıcıAldıgıKiteplar.Items.Add(txtKitapAd.Text);
                    DiziKitapAdı[k] = txtKitapAd.Text;

                    lstbAlıcıOgrenciNo.Items.Add(txtOgrenciNo.Text);
                    DiziÖğrenciNo[k] = Convert.ToInt32(txtOgrenciNo.Text);
                    using (StreamWriter KullanıcıKayıt = File.AppendText(Dosya))
                    {
                        KullanıcıKayıt.WriteLine(txtOgrenciad.Text.ToUpper());
                        KullanıcıKayıt.WriteLine(txtOgrenciSoyad.Text.ToUpper());
                        KullanıcıKayıt.WriteLine(txtOgrenciNo.Text.ToUpper());
                        KullanıcıKayıt.WriteLine(txtKitapAd.Text.ToUpper());
                        KullanıcıKayıt.WriteLine(txtKitapAdet.Text.ToUpper() + Environment.NewLine);
                    }

                    using (StreamWriter KullanıcıKayıt = File.AppendText(DosyaPath))
                    {
                        KullanıcıKayıt.Write(DiziÖğrenciAd[k].ToUpper() + " ");
                        KullanıcıKayıt.Write(DiziÖğrenciSoyad[k].ToUpper() + " ");
                        KullanıcıKayıt.Write(DiziÖğrenciNo[k] + " ");
                        KullanıcıKayıt.Write(DiziKitapAdı[k].ToUpper() + " ");
                        KullanıcıKayıt.Write(DiziKitapAdet[k] + " " + YirmiGünsonra + Environment.NewLine);
                    }
                    k++;
                    ToplamVerilenKitap += Convert.ToInt16(txtKitapAdet.Text);
                    lblVerilenKitapSayı.Text = ToplamVerilenKitap.ToString();
                    progressBar1.Value += 1;

                }

            }
            else
                MessageBox.Show("Eksik bilgi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnKitapTeslimAl_Click(object sender, EventArgs e)
        {

            if (txtKitapAd.Text != "" && txtKitapAdet.Text != "" && txtOgrenciad.Text != "" && txtOgrenciSoyad.Text != "" && txtOgrenciNo.Text != "")
            {

                for (int i = 0; i < 1000; i++)
                {
                    if (txtKitapAd.Text == DiziKitapAdı[i] && DiziÖğrenciAd[i] == txtOgrenciad.Text && DiziKitapAdet[i] == Convert.ToInt32(txtKitapAdet.Text) && DiziÖğrenciSoyad[i] == txtOgrenciSoyad.Text && DiziÖğrenciNo[i] == Convert.ToInt16(txtOgrenciNo.Text))
                    {


                        lstbAlıcıAd.Items.Remove(DiziÖğrenciAd[i]);
                        lstbAlıcıSoyad.Items.Remove(DiziÖğrenciSoyad[i]);
                        lstbAlıcıAldıgıKiteplar.Items.Remove(DiziKitapAdı[i]);
                        lstbAlıcıOgrenciNo.Items.Remove(DiziÖğrenciNo[i].ToString());
                        lstbAlıcıKitapAdet.Items.Remove(DiziKitapAdet[i].ToString());

                        lstbVerenAd.Items.Add(DiziÖğrenciAd[i]);
                        lstbVerenSoyad.Items.Add(DiziÖğrenciSoyad[i]);
                        lstbVerilenKitaplar.Items.Add(DiziKitapAdı[i]);
                        lstbOgrenciNo.Items.Add(DiziÖğrenciNo[i]);
                        lstbVerilenKitapAdet.Items.Add(DiziKitapAdet[i]);

                        lblDurum.Text = "Kitap geri alım";

                        if (ToplamVerilenKitap >= GerialınanKitaplar)
                        {
                            GerialınanKitaplar += Convert.ToInt16(txtKitapAdet.Text);
                            lblALınanKitapSayı.Text = GerialınanKitaplar.ToString();
                        }
                        DiziÖğrenciAd[i] = null;
                        DiziÖğrenciSoyad[i] = null;
                        DiziÖğrenciNo[i] = 0;
                        DiziKitapAdı[i] = null;
                        DiziKitapAdet[i] = 0;
                    }
                }

            }
            else
                MessageBox.Show("Eksik bilgi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            LblKitapKiralamaSayı.Text = ToplamCiro.ToString();
        }

        private void btnYeniBilgi_Click(object sender, EventArgs e)
        {
            txtKitapAd.Text = "";
            txtKitapAdet.Text = "";
            txtOgrenciad.Text = "";
            txtOgrenciSoyad.Text = "";
            txtOgrenciNo.Text = "";
            lblDurum.Text = "Yeni bilgi girişi";
        }

        private void btnArkaplanDeğiştir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ArkaPlan = new OpenFileDialog();
            ArkaPlan.Filter = " *.jpeg; *.jpg | *.jpeg; *.jpg";
            if (ArkaPlan.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = ArkaPlan.FileName;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                lblDurum.Text = "Arka plan değişti";
            }
        }

        private void btnKitapsüresiUzat_Click(object sender, EventArgs e)
        {
            ToplamCiro += KitapTarihiUzatma;
            MüşteriÖdenecek += KitapTarihiUzatma;
            lblMüşteriÖdencek.Text = MüşteriÖdenecek.ToString();
            lblDurum.Text = "Kitap süresi uzatıldı";
        }
        private void btnTeslimTarihi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(YirmiGünsonra.ToString());

        }

        int seciliindexs;
        private void cmbKitapUzatmaGünü_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliindexs = cmbKitapUzatmaGünü.SelectedIndex;
            if (seciliindexs <= 7)
            {
                KitapTarihiUzatma = 1;
            }
            if (seciliindexs <= 14 && seciliindexs > 7)
            {
                KitapTarihiUzatma = 2;
            }
            if (seciliindexs <= 21 && seciliindexs > 14)
            {
                KitapTarihiUzatma = 3;
            }
            if (seciliindexs <= 31 && seciliindexs > 21)
            {
                KitapTarihiUzatma = 4;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKitapDetay_Click(object sender, EventArgs e)
        {
            Kitapİçerik deteaylıKitapBilgisi = new Kitapİçerik();
            deteaylıKitapBilgisi.Show();
        }

        private void lstbArananKitap_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstbArananKitap_MouseDown(object sender, MouseEventArgs e)
        {
            Point Son = new Point(e.X, e.Y);

            int item = lstbArananKitap.IndexFromPoint(Son);

            if (e.Button == MouseButtons.Left)

            {

                lstbArananKitap.DoDragDrop(lstbArananKitap.Items[item], DragDropEffects.All);

            }
        }

        private void lstbArananKitap_DragOver(object sender, DragEventArgs e)
        {

        }

        private void lstAlınacakKitaplar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }

        private void lstAlınacakKitaplar_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                lstbArananKitap.Items.Clear();
                foreach (string KitapBilgisi in KitapArama)
                {
                    if (KitapBilgisi.ToLower().Contains(textBox2.Text.ToLower()))
                    {
                        lstbArananKitap.Items.Add(KitapBilgisi);
                    }
                }
            }
        }

        private void lstbArananKitap_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstbArananKitap.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
