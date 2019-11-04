using System;
using System.Windows.Forms;

namespace dongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DONGULER - LOOPS
        
        private void BtnOrn1_Click(object sender, EventArgs e)
        {

            //1. Bölüm başlangıç noktası; 2. bölüm karşılaştırma; 3. bölüm iterasyon
            // başlangıç. değeri bir defa indexlenir. sonradan değiştirmemek gerek. ayrıca bir defa işleme girer. değiştirildiği takdirde işlem patlar
            //daha sonraki işlemlerde koşul ve iterasyon arasında geçer. koşul sağlandığı takdirde döngüden çıkar.
            for (int i = 1; i <= 1000; i++)
            {
                listBox1.Items.Add(i);
            }

        }

        private void BtnOrn2_Click(object sender, EventArgs e)
        {

            //komut yazdıktan sonra iki defa tab tuşuna basarsan (örn: for "tab*2") komutun yazım şekli otomatik gelir. for örneği için sadece for yazı tab tab yaparsan arttırma şeklinde gelir. eğer eksilteceksek forr yazarız

            for (int i = 1000; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void BtnCift_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000; i += 2)
            {
                listBox1.Items.Add(i);

                //ya da 
                /*
                 for (int i = 0; i <=1000; i++)
                 {
                 if(i%2==0)
                 {
                 listBox1.Items.Add(i);
                 }
                 else{}
                 }
                 */
            }
        }

        private void BtnAZ_Click(object sender, EventArgs e)
        {
            for (char i = 'a'; i <= 'z'; i++) // eğer char yerine int bırakırsak harflerin ayısal karşılıklarını verirdi
            {
                listBox1.Items.Add($"{i} - {Convert.ToInt32(i)}"); // hem harfleri hem de sayısal değerlerini verir
            }
        }

        private void BtnToplam_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            
            for (int i = 1; i <= 100; i++)
            {
                toplam += i;                
            }
            MessageBox.Show("Toplam= " + toplam);
        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki çift sayıların toplamı ile tek sayıların toplamının farkları karesi kaçtır?

            int ctop = 0;
            int ttop = 0;

            /*
             for (int c = 0; c <= 100; c += 2)
            {
                ctop += c;
            }

            for (int t = 1; t < 100; t += 2)
            {
                ttop += t;
            }

            MessageBox.Show("İşlem sonucu = " + ((ctop - ttop)*(ctop - ttop)));
            */

            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    ctop += i;
                }
                else
                {
                    ttop += i;
                }
            }
            MessageBox.Show("İşlem sonucu = " + ((ctop - ttop) * (ctop - ttop)));
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //1945 - günümüz arasındaki yılları list boxa ekle ama 1990 ve 1992 eklenmesin

            /*
             for (int i = 1945; i < 2020; i++)
            {
                listBox1.Items.Add(i);
                listBox1.Items.Remove(1990);
                listBox1.Items.Remove(1992);            
            }
             */

            //soruda önce ekle sonra çıkar gibi bir şey dememiş. bu sebeple ekleme yapmadan direkt olarak 1990 ve 1992 yıllarının tespit edilip eklenMEmesi gerek. ayrıca şu formülle her yıl 2020 kısmının düzeltilmesi gerekir.

            for (int i = 1945; i < DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
