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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            // while (true)
            //{
            //    listBox1.Items.Add("A");
            //}

            // --Bu bir sonsuz döngüdür.
            // --for için sonsuz döngü ise şu şekildedir:

           //  for(; ; )
            //{
             //   listBox1.Items.Add("A");
           // }
            

            //while döngüsü, for döngüsünün parçalanmış halidir.

            int i = 1;
            while (i<=100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        Random rnd = new Random();
        private void Btn2_Click(object sender, EventArgs e)
        {
            //Form üzerinde yer alan butonları renklendirin
                       

            
             //for (int i = 0; i < Controls.Count; i++)
            //{
              //  if (Controls[i] is Button)
             //   {
              //      Controls[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
             //   }
           // }
             
            int i = 0;
            while (i < Controls.Count)
            {
                if (Controls[i] is Button)
                {
                    Controls[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
                i++;
            }
            
        }
    }
}
