using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüpane
{
    public partial class Kitapİçerik : Form
    {
        List<string> Kitaplar = new List<string>();
        Olasılıksız olasılıksız = new Olasılıksız();
        TanrıİnsandaUyurİnsandaUyanır tanrıİnsandaUyurİnsandaUyanır = new TanrıİnsandaUyurİnsandaUyanır();
        GaziMustafaKemalATATÜRK gaziMustafaKemalATATÜRK = new GaziMustafaKemalATATÜRK();
        Magisterium magisterium = new Magisterium();
        AşkVeÖzgürlük aşkVeÖzgürlük = new AşkVeÖzgürlük();
        string[] KitapYeri = new string[5];
        public Kitapİçerik()
        {
            InitializeComponent();
            Kitaplar.Add(olasılıksız.kitabınAdı + " " + olasılıksız.KitabınYazarı);
            Kitaplar.Add(tanrıİnsandaUyurİnsandaUyanır.kitabınAdı + " " + tanrıİnsandaUyurİnsandaUyanır.KitabınYazarı);
            Kitaplar.Add(gaziMustafaKemalATATÜRK.kitabınAdı + " " + gaziMustafaKemalATATÜRK.KitabınYazarı);
            Kitaplar.Add(magisterium.kitabınAdı + " " + magisterium.KitabınYazarı);
            Kitaplar.Add(aşkVeÖzgürlük.kitabınAdı + " " + aşkVeÖzgürlük.KitabınYazarı);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Clear();
                foreach (string Bul in Kitaplar)
                {
                    if (Bul.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        listBox1.Items.Add(Bul);
                    }
                }
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }


        private void DeteaylıKitapBilgisi_Load(object sender, EventArgs e)
        {
            KitapYeri[0] = (olasılıksız.kitabınAdı + " " + olasılıksız.KitabınYazarı);
            KitapYeri[1] = (tanrıİnsandaUyurİnsandaUyanır.kitabınAdı + " " + tanrıİnsandaUyurİnsandaUyanır.KitabınYazarı);
            KitapYeri[2] = (gaziMustafaKemalATATÜRK.kitabınAdı + " " + gaziMustafaKemalATATÜRK.KitabınYazarı);
            KitapYeri[3] = (magisterium.kitabınAdı + " " + magisterium.KitabınYazarı);
            KitapYeri[4] = (aşkVeÖzgürlük.kitabınAdı + " " + aşkVeÖzgürlük.KitabınYazarı);

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string secili = listBox1.Items[listBox1.SelectedIndex].ToString();
            if (KitapYeri[0] == secili)
            {
                richTextBox1.Text = "BİTİRMEK İÇİN YARINI, BAŞKASINA ANLATMAK İÇİN BİTİRMEYİ BEKLEMEYECEKSİNİZ.Olasılıksız demek yetersiz kalacaktır. İnsanı adeta büyüsü altına alan bu hikayede, Adam Fawer, bilim, felsefe, entrika ve maceradan ortaya bir başyapıt çıkarmış." +
                    "Clive Cussler İlk cümleden itibaren bağlanıp kaldım; sayfaları, floş royal tutturmaya çalışan bir kumarbazın kartlarını açtığı gibi çevirdim. Olasılıksız, insanı düşündüren" +
                    " matematik teorilerini ve maceranın albenisini dahice birleştiren, okura Michael Crichton ve Robert Ludlumu hatırlatan bir kitap.Gerçekten kaçırılmaması gereken bir zevk.Ben Mezrich," +
                    " Mekanı Batırmak ve Çirkin Amerikalıların yazarı…hikayenin sonunda, bir yandan şizofreninin gerçek nedenlerini düşünürken, bir yandan da tek bir hareketin bir insanın hayatını ne kadar değiştirebileceğin" +
                    "e şaşırıyor olacaksınız. Olasılıksız, beğeniceğinize gözümüz kapalı iddiaya girebileceğimiz bir kitap.PeopleBir sabah, yıllardır görmediğiniz bir arkadaşınızı düşünerek uyandınız. Bir saat sonra, onunla sokakta" +
                    " karşılaştınız.Sizce bu sadece bir tesadüf mü, yoksa çok daha farklı anlamı olabilir mi?Siz hiç Lotoda büyük ikramiye kazanmadınız. Ama birileri kazanıyor.Hem de sürekli!Onlar sizden daha mı şanslılar?" +
                    "Şans nedir gerçekten? İçinizde bütün paranızı kırmızıya yatırmanız gerektiğini söyleyen bir his var.Bu his bir öngörü müdür? Yoksa daha fazlası mı?Yolda gidiyorsunuz.Kafanızı çevirip yandaki küçük parka" +
                    " baktınız ve bir anda bu anı daha önce de yaşamış olduğunuzu hissettiniz.Evet, Deja Vu. Sizce nedir Deja Vu; Geçmiş mi, rüya mı, yoksa geleceği mi görüyorsunuz?" +
                    "Eğer siz de kontrölün kimde olduğunu merak ediyorsanız, Olasılıksız tam size göre bir roman.";
            }
            if (KitapYeri[1] == secili)
            {
                richTextBox1.Text = "Kitapta ele alınan mikrokozmos ile makrokozmos arasındaki benzerlikler holografij evren teorisinin ispatı niteliğindedir.Holografik evren teorisi ise evrenin ve yaratılışın en büyük gerçeğine vurgu yapar. Bu teori büyük bir uyanışın da habercisidir." +
                    "Bu uyanış, yüzyıllar öncesinden tasavvufçuların insanda Tanrısal sırlar gizlidir demelerinin ne anlama geldiğini gün ışığına çıkarmıştır." +
                    "Hallac - ı Mansur da En - el Haksözüyle insanın bu yönünü canı pahasını dile getirmiştir. Yunus Emre Bir ben var benden içre demiştir.Mevlana da  hem kendi içinde hem de döndüğü her yerde O nun yüzünü gördüğünü söylenmiştir." +
                    " Tanrıyı tek bir yerde aramayın, O ne yerdedir ne de gökte... Çünkü O her yerdedir. Her insanın içindedir.Her zerrededir." +
                    "Aşağısı yukarıya, yukarısı aşağıya benzer. Ve en küçük zerre bile bütüne ait bilgi taşır.Bu sonsuz sınırsız evrenin ve varoluşun temel ezoterik prensibidir." +
                    "Tanrıyı çok uzaklarda aramayın O nu belki de göz yaşınızda bile bulabilirsiniz, çünkü her varlığın içinde Tanrı dan bir öz vardır. İnsanoğlu bir gün bu sırrı iç yüzünü anladığında, içindeki Tanrı uyanmaya başlayacak ve gerçeği kendi kalbinde bulacak... Peki ama bu gerçeği nasıl kavrayacağız." +
                    "Bunu sözel olarak duymak, bu gerçekle bizi yüz yüze getirmez.Bunun için özel bir çaba ve çalışma gereklidir. Bu nedenle bir zamanlar mabetlerin içinde özel inisiyatik çalışmalar gerçekleştirilmekte ve bu gerçekle inisiyeler yüz yüze getirilmekteydi.Bu inisiyelerin yaşadıkları miraçlarıyladı. Bu aydınlanma halini tasavvuf terminolojisindeki karşılığı, içsel kıyamete doğru süren bir yükselişti." +
                    "Bu devrin sonlarında geldiğimiz bu günlerdeki gidişat, bu miracın insanlık tarafından yaşanmasıyla sonuçlanacaktır.Yayınladığımız bu kitap, bu yolda sizi hedefinize ulaştıracak değildir. Ancak küçük de olsa, atacağınız bu yoldaki adımınıza bir güç katacaktır.";
            }
            if (KitapYeri[2] == secili)
            {
                richTextBox1.Text = "Gazi Mustafa Kemal Atatürk kitabı, evvela imparatorluğu dirilten nesil olan 1880'liler kuşağı, Balkan coğrafyası ve Mustafa Kemal'in aile kökeni ile başlıyor." +
                    "Akabinde Atatürk’ün askeri eğitimi, Manastır yılları, Milliyetçilikler Dönemi, İttihat ve Terakki, II.Abdülhamid, Enver Paşa, Ziya Gökalp, Trablusgarb, Balkan Savaşları ve Sofya yıllarıyla devam ediyor." +
                    "Ordumuzun İtilaf devletleriyle sekiz cephede mücadele ettiği Birinci Dünya Savaşı, kutlu zaferlerimiz Çanakkale ve Kutü’l Amâre, Mondros, son padişah Vahideddin, bir milletin ve ülkenin ölüm fermanı olan Sevr…" +
                    "Tüm detaylarıyla Milli Mücadele dönemi, 23 Nisan 1920 ve sonrasında muhalefete rağmen verilen Kurtuluş Savaşı, İnönü Muharebeleri, Lozan Konferansı, Büyük Taarruz ve Cumhuriyet’e giden yol..." +
                    "Saltanat ve hilafet tartışmaları, Lozan, On İki Ada, mübadele, Osmanlı dan kalan borçlar, Musul ve yakın tarihin en önemli meselesi olan inkılablar..." +
                    "Son olarak kişisel özellikleriyle, dünyada, anılarda, hafızalarda kalan izleriyle modern Türkiye’nin kurucusu Atatürk..." +
                    "İlber Ortaylı bu ilk biyografisinde yaşamının tüm yönleriyle büyük lider Gazi Mustafa Kemal Atatürk ü anlatıyor. Türk tarihçiliğine hiç unutulmayacak ve sürekli başvurulacak bir rehber kitap daha kazandırıyor...";
            }
            if (KitapYeri[3] == secili)
            {
                richTextBox1.Text = "Asla bir büyücüye güvenme ... Callum'un yaşındaki pek çok genç , onun yerinde olmak isterdi . Özel büyü yeteneklerine sahip olmak ve efsane okul Magisteriu ma kabul edilmek herkesin rüyasıydı.Buraya girenler, " +
                    "ilk adım olan Demir Yılı tamamlayarak , güçlerini nasıl kullanacaklarını öğreniyordu .Oysa Callum Hunt , diğerlerinden çok farklıydı .Tüm hayatı boyunca ona , bir büyücüye güvenmemesi gerektiği söylenmişti . Bu yüzden tek şansı vardı " +
                    ": elinden gelenin e n kötüsünü yapmak .Fakat başarısı z olma konusunda başarısız olmuştu! Şimdi o ürk ünç okula kaydolmak zorundaydı . Geçmişiyle karanlık bir bağı olan ve geleceğini der inde n etk ileyen o uğursuz okula ... Demir Yıl , " +
                    "sadece bir başlangıçtı . Cal lu n en büyük sınavı ise adım adım yaklaşıyordu...";
            }
            if (KitapYeri[4] == secili)
            {
                richTextBox1.Text = "Kendini sev... Birbirinizi sevin ama aşktan bağlar üretmeyin. Aşk bir armağan olmalı, ama bedeli olmamalı...Aşk bağlılığa dönüştüğü anda ilişki haline gelir.Aşk taleplerde bulunduğu anda hapishaneye benzer." +
                    " Özgürlüğünü elinden alır; göklerde uçamazsın, kafeslenmişsindir.Aşkın özgürlük verici bir kalitede olması lazım, sana zincir vurması değil; sana kanat takıp mümkün olduğunca yükseklere uçmanı sağlaması lazım." +
                    "Senin bildiğin aşk biyolojik bir dürtüden ibaret; hormonlarınla kimyandan kaynaklanıyor.Kolaylıkla değişebilir-kimyandaki ufacık bir değişim en yüce gerçek sandığın o aşkın yok olmasına yetecektir. Sen tutkuya aşk diyorsun." +
                    "Aşk sadece vermeyi bilir ve asla karşılık beklemez; aşk koşulsuz paylaşımdır.Gerçek aşkı asla hayal kırıklığına uğratamazsın, çünkü zaten baştan bir beklenti yoktur.Gerçek olmayan aşkı ise asla tatmin edemezsin çünkü öylesine büyük bir beklenti içindedir ki yapılan her şey az gelir." +
                    "Aşk yaşamının en büyük deneyimidir ve aşk enerjisi ile deneyimlere girmeden yaşayanlar hayatın ne olduğunu asla öğrenemezler.Fazla derinlere inmeden yaşamın yüzeyinde kalırlar." +
                    "Aşk olduğu zaman seven ve sevilen birlikte aşkın içinde kaybolur. Eğer özgürlük ve aşka sahip olursan başka şeye ihtiyacın kalmaz.Elde etmişsindir-sana yaşam işte bunun için verildi.";
            }
        }

        private void Kitapİçerik_Load(object sender, EventArgs e)
        {
            KitapYeri[0] = (olasılıksız.kitabınAdı + " " + olasılıksız.KitabınYazarı);
            KitapYeri[1] = (tanrıİnsandaUyurİnsandaUyanır.kitabınAdı + " " + tanrıİnsandaUyurİnsandaUyanır.KitabınYazarı);
            KitapYeri[2] = (gaziMustafaKemalATATÜRK.kitabınAdı + " " + gaziMustafaKemalATATÜRK.KitabınYazarı);
            KitapYeri[3] = (magisterium.kitabınAdı + " " + magisterium.KitabınYazarı);
            KitapYeri[4] = (aşkVeÖzgürlük.kitabınAdı + " " + aşkVeÖzgürlük.KitabınYazarı);
        }
    }
}
