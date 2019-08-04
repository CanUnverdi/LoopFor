using System;
using System.Collections.Generic;
using System.Text;

namespace LoopFor
{
    class Class1
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnArtan_Click(object sender, EventArgs e)
        {
           
            for (int i = 1; i < 1000; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnAzalan_Click(object sender, EventArgs e)
        {
            
            for (int i = 999; i >= 0; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnCiftSayilar_Click(object sender, EventArgs e)
        {
           
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void btnAlfabe_Click(object sender, EventArgs e)
        {
 
            for (char i = 'A'; i <= 'Z'; i++)
            {
                listBox1.Items.Add(i + " - " + Convert.ToInt32(i));
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
           
            int sonuc = 0;
            for (int i = 0; i < 100; i++)
            {
                sonuc = sonuc + i;
            }
            MessageBox.Show("Sonuç " + sonuc);
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
        
            int ciftlerinToplami = 0;
            int teklerinToplami = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftlerinToplami += i;
                }
                else
                {
                    teklerinToplami += i;
                }
            }
            int sonuc = (ciftlerinToplami - teklerinToplami) * (ciftlerinToplami - teklerinToplami);
            MessageBox.Show("Sonuç: " + sonuc);
        }

        private void btnYillar_Click(object sender, EventArgs e)
        {
          
            for (int i = 1945; i < DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 100; i++)
            {
                if (i == 20)
                {
                    listBox1.Items.Add(i);
                    break;
                  
                }
                listBox1.Items.Add(i);
            }
            MessageBox.Show("Döngüden çıktık e işlemlere devma ediyoruz");
        }

        private void btnContiune_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear();

            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                int karmasikSayi = rnd.Next(1, 10);
                if (listBox1.Items.Contains(karmasikSayi))
                {
                    
                    i--;
                    continue;
                }
                else
                {
                    listBox1.Items.Add(karmasikSayi);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (i == 20)
                {
                    listBox1.Items.Add(i);
                    return;
                    MessageBox.Show("Test");
                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }
            MessageBox.Show("Döngüden çıktık ve işlemlerimize devam ediyoruz");
        }
}
