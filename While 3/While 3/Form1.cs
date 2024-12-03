using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int toplam = 0;
            int sayi;
            while (i <= 20)
            {
                sayi = rast.Next(1, 100);
                toplam = toplam + sayi;
                listBox1.Items.Add(sayi);
                i++;
            }
            MessageBox.Show("Bütün Sayıların Toplamı: " + toplam);
        }
    }
}
