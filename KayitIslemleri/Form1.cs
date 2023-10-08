using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitIslemleri
{
    
    public partial class Form1 : Form
    {
        List<Kisi> kisiler = new List<Kisi>();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<Kisi>kisileri)
        {
            InitializeComponent();
            foreach (Kisi kisi in kisileri)
            {
                kisiler.Add(kisi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        public void Form1Guncelle()
        {
            foreach (Kisi kisi in kisiler)
            {
                lbKisiler.Items.Add($"{kisi.AdSoyad}");
            }
        }

        private void lbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = lbKisiler.SelectedIndex;
            string info = $"Adi Soyadi : {kisiler[indeks].AdSoyad}\n" + 
                $"Yasi : {kisiler[indeks].Yas}\n" +
                $"Telefonu: {kisiler[indeks].Telefon}\n" +
                $"Adresi : {kisiler[indeks].Adres}";

            MessageBox.Show(info, "Musteri Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
