using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dongu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void BtnOrn1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };

            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void BtnOrn2_Click(object sender, EventArgs e)
        {
            //2'ye bölünenleri lb1'e, bölünmeyenleri lb2'ye atın. Hem 2'ye hem 3'e bölünenlerin kaç tane olduğunu mb ile yazın

            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };

            int tambolunen = 0;
            foreach (int bolunen in dizi)
            {
                if (bolunen % 2 == 0)
                {
                    listBox1.Items.Add(bolunen);
                }
                else
                {
                    listBox2.Items.Add(bolunen);
                }

                if (bolunen % 2 == 0 && bolunen %3 == 0)
                {
                    tambolunen++;                    
                }
            }
            MessageBox.Show("Hem 2'ye hem 3'e bölünen sayıların adedi: " + tambolunen.ToString());
        }

        private void BtnOrn3_Click(object sender, EventArgs e)
        {
            //lb1'deki seçili tüm elemanları (birden fazla seçim yapılabilmeli) lb2'ye ekleyin

            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Remove(item); 
            }
        }

        Random rnd = new Random();
        private void BtnOrn4_Click(object sender, EventArgs e)
        {
            //form üzerindeki tüm butonların arka planları ve yazı renklerini değiştirin

            foreach (Control nesne in Controls)
            {
                if (nesne is Button)
                {
                    nesne.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    nesne.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }
    }
}
