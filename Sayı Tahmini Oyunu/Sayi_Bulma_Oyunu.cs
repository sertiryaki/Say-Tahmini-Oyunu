using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Tahmini_Oyunu
{
    public partial class Form1 : Form
    {
        int tutulanSayi;
        int tahminSayisi;
        int tahmin;
        Random rnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            tutulanSayi = rnd.Next(1, 101);
            tahminSayisi = 0;
        }

        private void btnTahminet_Click(object sender, EventArgs e)
        {
            tahmin = int.Parse(txtTahmin.Text);
            //tahminSayisi = tahminSayisi + 1;
            tahminSayisi++;
            if (tutulanSayi > tahmin)
            {
                MessageBox.Show("Daha YÜKSEK bir sayı gir.");
            }
            else if (tutulanSayi < tahmin)
            {
                MessageBox.Show("Daha DÜŞÜK bir sayı gir.");
            }
            else
            {
                DialogResult cevap = MessageBox.Show(
                    $"Tebrikler! Doğru tahmin. {tahminSayisi} denemede buldunuz.\nTekrar oynamak ister misiniz?",
                    "TEBRİKLER",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    tutulanSayi = rnd.Next(1, 101);
                    tahminSayisi = 0;
                }
                else if (cevap == DialogResult.No)


                {
                    this.Close();
                }


            }

            txtTahmin.Clear();
            txtTahmin.Focus();
        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtTahmin.Focus();
        }

        private void txtTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTahminet.PerformClick();
            }
        }
    }
}
