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
            
            for (int i =1; i < 6; i++)
            {
                 label1.Text += "X";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i < 6; i++)
            {
                label1.Text = "X\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                
                for (int a = 0; a < 15; a++)
                {
                    label1.Text += "X";
                }
                label1.Text += "\n";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= 10; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    label1.Text += "X ";                    
                }
                label1.Text += "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bas = "ve Katları";
            
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add("----------------");
                listBox1.Items.Add($"{i} {bas}");
                
                for (int k = 1; k <= 10; k++)
                {
                    int carpım = i * k;
                    listBox1.Items.Add($"{i} x {k} = {carpım}");
                }
                listBox1.Items.Add("----------------");
            }
        }
    }
}
