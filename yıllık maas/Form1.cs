using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yıllık_maas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double maas = 0;
        double yillikArtisOrani = 0;
        double yillikArtis = 0;
        int yil = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            maas = Convert.ToDouble(textBox1.Text);
            yillikArtisOrani = Convert.ToDouble(textBox2.Text);
            yil = Convert.ToInt32(textBox3.Text);
            for (int i = 1; i <= yil; i++)
            {
                yillikArtis = (maas / 100) * yillikArtisOrani;
                maas = maas + yillikArtis;
            }

            label4.Text= Convert.ToString(yil) + " sonunda "
               + "yıllık " + Convert.ToString(yillikArtisOrani) + "%" + " artış ile " +
               Convert.ToString(Math.Round(maas, 2)) + "TL alacaksınız";
        }
    }
}
