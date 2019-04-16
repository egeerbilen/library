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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        int sayi;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanıcı.Text == "admin" && int.TryParse((txtKullanıcıSifre.Text), out sayi) && txtKullanıcıSifre.Text == "123")
            {
                Personel Per = new Personel();
                Per.Show();
                this.Hide();

            }
        }
    }
}
