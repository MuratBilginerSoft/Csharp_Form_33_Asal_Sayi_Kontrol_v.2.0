using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Asal_Sayı_Kontrol_v2._0_Corona
{
    public partial class Form1 : Form
    {
        AsalKontrol ASK=new AsalKontrol();
        private int sayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicOnay.BackgroundImage = Image.FromFile("Soru.png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                sayi = int.Parse(textBox1.Text);

                ASK.AsalBul(sayi, PicOnay);
            }
            catch (Exception)
            {

                MessageBox.Show("Sadece sayı girişi yapabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PicOnay.BackgroundImage = Image.FromFile("Soru.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
