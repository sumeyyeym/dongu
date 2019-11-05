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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = "x";

            for (int i =1; i < 6; i++)
            {
                 label1.Text = label1.Text +" "+ x;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = "x";

            for (int i = 1; i < 6; i++)
            {
                label1.Text = label1.Text + "\r\n" + x;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = "x";
            for (int i = 1; i < 11; i++)
            {
                label1.Text = label1.Text + "\r\n" + x;
                for (int a = 1; a < 11; a++)
                {
                    label1.Text = label1.Text + "  " + x;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string taban = "abcdef";
            
            for (int i = 0; i < taban.Length; i++)
            {
                for (int a = 0; a <= i; a++)
                {
                    label1.Text = label1.Text + taban[i];                    
                }                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bas = "ve Katları";
            string tire = "-----------";

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(tire);
                listBox1.Items.Add($"{i} {bas}");
                listBox1.Items.Add(tire);

                for (int k = 1; k <= 10; k++)
                {
                    int carpım = i * k;
                    listBox1.Items.Add($"{i}*{k}={carpım}");
                }
            }
        }
    }
}
